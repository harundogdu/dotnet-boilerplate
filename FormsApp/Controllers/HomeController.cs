using FormsApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FormsApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(string searchString)
        {
            var products = Repository.Products;

            if (!string.IsNullOrEmpty(searchString))
            {
                products = products.FindAll(p => p.Name.Contains(searchString, StringComparison.CurrentCultureIgnoreCase));
            }

            ViewBag.SearchString = searchString;
            ViewBag.Categories = new SelectList(Repository.Categories, "CategoryId", "Name"); // açıklama: SelectList sınıfı, bir veri koleksiyonunu bir DropDownList veya ListBox denetimine bağlamak için kullanılır. İlk parametre, veri koleksiyonunu, ikinci parametre, DropDownList veya ListBox denetiminde görünecek metin ve üçüncü parametre, DropDownList veya ListBox denetiminde görünecek değerdir.

            return View(products);
        }
    }
}