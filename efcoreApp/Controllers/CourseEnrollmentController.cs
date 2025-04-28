using System.Threading.Tasks;
using efcoreApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace efcoreApp.Controllers
{
    public class CourseEnrollmentController : Controller
    {
        private readonly DataContext _context;
        public CourseEnrollmentController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            ViewBag.Courses = new SelectList(await _context.Courses.ToListAsync(),"CourseId","CourseTitle");
            ViewBag.Students = new SelectList(await _context.Students.ToListAsync(), "StudentId", "FirstName");
            return View();
        }

        public IActionResult Enroll(){
            return View();
        }
    }
}