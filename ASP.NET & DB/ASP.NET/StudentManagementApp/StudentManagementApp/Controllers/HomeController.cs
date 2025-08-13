using Microsoft.AspNetCore.Mvc;
using StudentManagementApp.Models;
using System.Diagnostics;

namespace StudentManagementApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // GET: Home/Index
        public IActionResult Index()
        {
            return View();  // This will return the view located at Views/Home/Index.cshtml
        }

        // GET: Home/Privacy
        public IActionResult Privacy()
        {
            return View();
        }

        // Error handling view (optional, can be used for error pages)
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
