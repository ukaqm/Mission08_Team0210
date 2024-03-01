using Microsoft.AspNetCore.Mvc;
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

        public IActionResult Index()
        {
            var viewstuff = _repo.Tasks.ToList();

            return View(viewstuff);
        }
    }
}
