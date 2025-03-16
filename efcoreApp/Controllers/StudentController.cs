using System.Threading.Tasks;
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

        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            var student = await _context.Students.FindAsync(id);
            // var student = await _context.Students.FirstOrDefaultAsync(x => x.StudentId == id); // Bu şekilde de yapılabilir. Bu şekilde farklı kolonlar üzerinden de arama yapılabilir.

            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, Student model)
        {
            var student = await _context.Students.FindAsync(id);

            if (student == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    student.FirstName = model.FirstName;
                    student.LastName = model.LastName;
                    student.Email = model.Email;
                    student.PhoneNumber = model.PhoneNumber;
                    student.BirthTime = model.BirthTime;
                    await _context.SaveChangesAsync();
                    return RedirectToAction("Index");
                }
                catch (System.Exception ex)
                {
                    ModelState.AddModelError("", "An error occurred while updating the student.");
                    return View(model);
                }
            }

            return View(student);
        }
    }
}