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
        var courses = new List<Course>(){
            new Course{Id = 1, Title = "ASP.NET Core MVC", Description = "Learn ASP.NET Core MVC from scratch.", Image = "1.jpg"},
            new Course{Id = 2, Title = "ASP.NET Core Web API", Description = "Learn ASP.NET Core Web API from scratch.", Image = "2.jpg"},
            new Course{Id = 3, Title = "ASP.NET Core Blazor", Description = "Learn ASP.NET Core Blazor from scratch.", Image = "3.jpg"},
            new Course{Id = 4, Title = "ASP.NET Core SignalR", Description = "Learn ASP.NET Core SignalR from scratch.", Image = "4.jpg"},
        };
        return View("CourseList", courses);
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
