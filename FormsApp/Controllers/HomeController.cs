using FormsApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FormsApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(string? searchString, string? categoryId)
        {
            var products = Repository.Products;

            if (!string.IsNullOrEmpty(searchString))
            {
                products = products.FindAll(p => p.Name.Contains(searchString, StringComparison.CurrentCultureIgnoreCase));
            }

            if (!string.IsNullOrEmpty(categoryId) && categoryId != "0")
            {
                products = [.. products.Where(p => p.CategoryId == int.Parse(categoryId))];
            }

            ViewBag.SearchString = searchString;
            // ViewBag.Categories = new SelectList(Repository.Categories, "CategoryId", "Name", categoryId); // açıklama: SelectList sınıfı, bir veri koleksiyonunu bir DropDownList veya ListBox denetimine bağlamak için kullanılır. İlk parametre, veri koleksiyonunu, ikinci parametre, DropDownList veya ListBox denetiminde görünecek metin ve üçüncü parametre, DropDownList veya ListBox denetiminde görünecek değerdir.

            var model = new ProductViewModel
            {
                Products = products,
                Categories = Repository.Categories,
                SelectedCategory = categoryId
            };

            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Categories = Repository.Categories;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Product product, IFormFile imageFile)
        {

            var extension = Path.GetExtension(imageFile.FileName);
            var allowedExtensions = new[] { ".jpg", ".jpeg", ".png", ".gif" };

            if (!allowedExtensions.Contains(extension))
            {
                ModelState.AddModelError("imageFile", "Invalid image file extension");
            }

            if (ModelState.IsValid)
            {
                if (imageFile != null)
                {
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img", Guid.NewGuid().ToString() + extension);
                    var fileName = Path.GetFileName(path);

                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await imageFile.CopyToAsync(stream);
                    }

                    product.ImageUrl = fileName;
                }

                Repository.AddProduct(product);

                return RedirectToAction("Index");
            }

            ViewBag.Categories = Repository.Categories;
            return View(product);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            if (Repository.GetProductById(id) == null)
            {
                return View("NotFound");
            }
            
            var product = Repository.GetProductById(id);

            if (product == null)
            {
                return View("NotFound");
            }

            ViewBag.Categories = Repository.Categories;
            return View(product);
        }

        [HttpPost]
        public IActionResult Edit(Product product, IFormFile imageFile)
        {
            return RedirectToAction("Index");
        }
    }
}