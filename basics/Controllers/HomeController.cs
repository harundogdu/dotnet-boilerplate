using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using basics.Models;

namespace basics.Controllers;

public class HomeController : Controller
{

    public IActionResult Index()
    {
        var courses = Repository.Courses;
        return View(courses);
    }

    public IActionResult Contact()
    {
        return View();
    }

}
