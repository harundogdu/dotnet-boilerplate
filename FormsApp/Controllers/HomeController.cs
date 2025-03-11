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
        public IActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                var maxId = Repository.Products.Max(p => p.ProductId) + 1;
                product.ProductId = maxId;
                Repository.AddProduct(product);
                return RedirectToAction("Index");
            }

            ViewBag.Categories = Repository.Categories;
            return View(product);
        }
    }
}