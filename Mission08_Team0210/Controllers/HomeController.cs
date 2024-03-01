using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mission08_Team0210.Models;
using System.Diagnostics;

namespace Mission08_Team0210.Controllers
{
    public class HomeController : Controller
    {

        private ToDoListContext _context;
        public HomeController(ToDoListContext temp) // constructor
        {
            _context = temp;
        }
        // private readonly ILogger<HomeController> _logger;

        // public HomeController(ILogger<HomeController> logger)
        // {
        //     _logger = logger;
        // }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Quadrants()
        {
            var quadrants = _context.Tasks
                .OrderBy(x => x.TaskId).ToList();

            return View(quadrants);
        }
    }
}
