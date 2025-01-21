
namespace basics.Models;

public class Repository
{
    public static readonly List<Course> _courses = [];

    static Repository()
    {
        _courses = [
            new Course
            {
                Id = 1,
                Title = "C# Basics",
                Image = "1.jpg",
                Description = "Learn the basics of C# programming language.",
                Tags = ["C#", "Programming", "Basics"],
                IsActive = true,
                IsHome = true,
                IsNew = true,
                ReleaseDate = new DateOnly(2021, 1, 1),
                RegisteredUsersCount = 100
            },
            new Course
            {
                Id = 2,
                Title = "C# Intermediate",
                Image = "2.jpg",
                Description = "Learn the intermediate topics of C# programming language.",
                Tags = ["C#", "Programming", "Intermediate"],
                IsActive = true,
                IsHome = true,
                IsNew = false,
                ReleaseDate = new DateOnly(2021, 1, 1),
                RegisteredUsersCount = 50
            },
            new Course
            {
                Id = 3,
                Title = "C# Advanced",
                Image = "3.jpg",
                Description = "Learn the advanced topics of C# programming language.",
                Tags = ["C#", "Programming", "Advanced"],
                IsActive = true,
                IsHome = false,
                IsNew = true,
                ReleaseDate = new DateOnly(2021, 1, 1),
                RegisteredUsersCount = 25
            },
            new Course
            {
                Id = 4,
                Title = "ASP.NET Core",
                Image = "4.jpg",
                Description = "Learn the basics of ASP.NET Core.",
                Tags = ["ASP.NET Core", "Web Development", "Basics"],
                IsActive = false,
                IsHome = true,
                IsNew = false,
                ReleaseDate = new DateOnly(2021, 1, 1),
                RegisteredUsersCount = 75
            },
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