using FormsApp.Models;
using Microsoft.AspNetCore.Mvc;

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

            return View(products);
        }
    }
}