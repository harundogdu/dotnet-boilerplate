using System;
using basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace basics.Controllers;

public class CourseController : Controller
{
    public IActionResult Index()
    {
        return RedirectToAction("List", "Course");
    }
    public IActionResult List()
    {
        return View("CourseList", Repository.Courses);
    }

    public IActionResult Details(int? id)
    {
        if (id is null)
        {
            return RedirectToAction("List", "Course");
        }

        var course = Repository.GetById(id);

        if (course is null)
        {
            return RedirectToAction("List", "Course");
        }

        return View(course);
    }
}
