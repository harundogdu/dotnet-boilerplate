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
        return View(course);
    }

    public IActionResult List()
    {
        var courses = new List<Course>(){
            new Course{Id = 1, Title = "ASP.NET Core MVC", Description = "Learn ASP.NET Core MVC from scratch."},
            new Course{Id = 2, Title = "ASP.NET Core Web API", Description = "Learn ASP.NET Core Web API from scratch."},
            new Course{Id = 3, Title = "ASP.NET Core Blazor", Description = "Learn ASP.NET Core Blazor from scratch."},
            new Course{Id = 4, Title = "ASP.NET Core SignalR", Description = "Learn ASP.NET Core SignalR from scratch."},
        };
        return View("CourseList", courses);
    }
}
