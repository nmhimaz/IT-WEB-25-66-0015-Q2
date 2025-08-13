using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentManagementApp.Models;

namespace StudentManagementApp.Controllers
{
    public class StudentController : Controller
    {
        private readonly StudentContext _context;

        public StudentController(StudentContext context)
        {
            _context = context;
        }

        // GET: Students
        public IActionResult Index()
        {
            var students = _context.Students.Include(s => s.Course).ToList();
            return View(students);  // Passes the list of students with their courses to the view
        }



        // GET: Students/Create
        public IActionResult Create()
        {
            ViewBag.Courses = _context.Courses.ToList();
            return View();
        }

        // POST: Students/Create
        [HttpPost]
        public IActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                _context.Students.Add(student);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            ViewBag.Courses = _context.Courses.ToList();
            return View(student);
        }
    }
}
