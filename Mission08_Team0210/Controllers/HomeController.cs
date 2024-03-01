using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mission08_Team0210.Models;
using System.Diagnostics;

namespace Mission08_Team0210.Controllers
{
    public class HomeController : Controller
    {
        private IToDoRepository _repo;

        public HomeController(IToDoRepository temp)
        {
            _repo = temp;
        }
        // private readonly ILogger<HomeController> _logger;

        // public HomeController(ILogger<HomeController> logger)
        // {
        //     _logger = logger;
        // }

        public IActionResult Index()
        {
            var viewstuff = _repo.Tasks.ToList();

            return View(viewstuff);
        }
        public IActionResult Quadrants()
        {
            var quadrants = _context.Tasks
                .OrderBy(x => x.TaskId).ToList();

            return View(quadrants);
        }
    }
}
