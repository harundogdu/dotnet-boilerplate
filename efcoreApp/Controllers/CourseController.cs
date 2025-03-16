using System.Threading.Tasks;
using efcoreApp.Data;
using Microsoft.AspNetCore.Mvc;

namespace efcoreApp.Controllers
{
    public class CourseController : Controller
    {
        private readonly DataContext _context;

        public CourseController(DataContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var courses = _context.Courses.ToList();
            return View(courses);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Course course)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Courses.Add(course);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("Index");
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return View(course);
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            var course = _context.Courses.Find(id);

            if (course == null)
            {
                return NotFound();
            }

            return View(course);
        }


        [HttpPost]
        public IActionResult Edit(int id, Course model)
        {
            var course = _context.Courses.Find(id);

            if (course == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    course.CourseTitle = model.CourseTitle;
                    _context.SaveChangesAsync();
                    return RedirectToAction("Index");
                }
                catch (Exception)
                {
                    ModelState.AddModelError("", "An error occurred while updating the course.");
                    return View(model);
                }
            }

            return View(model);

        }

    }
}