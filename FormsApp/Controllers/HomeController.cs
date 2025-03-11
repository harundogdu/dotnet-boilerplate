using FormsApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FormsApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(Repository.Products);
        }
    }
}