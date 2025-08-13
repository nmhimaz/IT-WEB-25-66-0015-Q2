using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentManagementApp.Models;

namespace StudentManagementApp.Controllers
{
    public class CourseController : Controller
    {
        private readonly StudentContext _context;

        public CourseController(StudentContext context)
        {
            _context = context;
        }

        // GET: Courses
        public IActionResult Index()
        {
            var courses = _context.Courses.ToList();
            return View(courses);
        }

        // GET: Courses/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Courses/Create
        [HttpPost]
        public IActionResult Create(Course course)
        {
            if (ModelState.IsValid)
            {
                _context.Courses.Add(course);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(course);
        }
    }
}
