using meetingApp.Models;
using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class MeetingController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Apply()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Apply(UserInfo model)
        {
            Repository.CreateUser(model);
            ViewBag.AttendeesCount = Repository.Users.Where(info => info.WillAttend == true).Count();
            return View("Thanks", model);
        }

        [HttpGet]
        public IActionResult List()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Detail()
        {
            return View();
        }
    }
}