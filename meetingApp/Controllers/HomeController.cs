using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            int currentHour = DateTime.Now.Hour;

            // ViewBag.UserName = "Harun";

            ViewData["Time"] = currentHour > 12 ? "İyi günler" : "Günaydın";
            ViewData["UserName"] = "Harun";
            return View();
        }
    }
}