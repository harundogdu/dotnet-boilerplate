using efcoreApp.Data;
using Microsoft.AspNetCore.Mvc;

namespace efcoreApp.Controllers
{
    public class StudentController : Controller
    {
        private readonly DataContext _context;

        public StudentController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var students = _context.Students.ToList();
            return View(students);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Student student)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Students.Add(student);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
                }
                catch (System.Exception)
                {
                    throw;
                }
            }

            return View(student);
        }

    }
}