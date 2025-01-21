using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            int currentHour = DateTime.Now.Hour;
            ViewData["Time"] = currentHour > 12 ? "İyi günler" : "Günaydın";
            return View();
        }
    }
}