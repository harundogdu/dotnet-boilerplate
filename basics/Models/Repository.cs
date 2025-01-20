
namespace basics.Models;

public class Repository
{
    public static readonly List<Course> _courses = [];

    static Repository()
    {
        _courses = [
            new Course{Id = 1, Title = "ASP.NET Core MVC", Description = "Learn ASP.NET Core MVC from scratch.", Image = "1.jpg"},
            new Course{Id = 2, Title = "ASP.NET Core Web API", Description = "Learn ASP.NET Core Web API from scratch.", Image = "2.jpg"},
            new Course{Id = 3, Title = "ASP.NET Core Blazor", Description = "Learn ASP.NET Core Blazor from scratch.", Image = "3.jpg"},
            new Course{Id = 4, Title = "ASP.NET Core SignalR", Description = "Learn ASP.NET Core SignalR from scratch.", Image = "4.jpg"},
        ];
    }

    public static List<Course> Courses
    {
        get
        {
            return _courses;
        }
    }

    public static Course? GetById(int? id)
    {
        return _courses.FirstOrDefault(course => course.Id == id);
    }

}