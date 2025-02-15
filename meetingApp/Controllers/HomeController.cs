using MeetingApp.Models;
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
            // ViewData["UserName"] = "Harun";
            var meetingInfo = new MeetingInfo()
            {
                Id = 1,
                Location = "Ankara, Meb şura salonu",
                Date = new DateTime(2025, 01, 11, 20, 0, 0),
                NumberOfPeople = 100
            };
            return View(meetingInfo);
        }
    }
}