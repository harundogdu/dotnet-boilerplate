using meetingApp.Models;
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
            int NumberOfPeople = Repository.Users.Where(info => info.WillAttend == true).Count();

            var meetingInfo = new MeetingInfo()
            {
                Id = 1,
                Location = "Ankara, Meb şura salonu",
                Date = new DateTime(2025, 01, 11, 20, 0, 0),
                NumberOfPeople = NumberOfPeople
            };
            return View(meetingInfo);
        }
    }
}