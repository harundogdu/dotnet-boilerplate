using System;
using basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace basics.Controllers;

public class CourseController : Controller
{
    public IActionResult Index()
    {
        var course = new Course();
        course.Id = 1;
        course.Title = "ASP.NET Core MVC";
        course.Description = "Learn ASP.NET Core MVC from scratch.";
        course.Image = "1.jpg";
        return View(course);
    }

    public IActionResult List()
    {
        return View("CourseList", Repository.Courses);
    }

    public IActionResult Details()
    {
        var course = new Course();
        course.Id = 1;
        course.Title = "ASP.NET Core MVC";
        course.Description = "Learn ASP.NET Core MVC from scratch.";
        course.Image = "1.jpg";
        return View(course);
    }
}
