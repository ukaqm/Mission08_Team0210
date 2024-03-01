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

        public IActionResult Index()
        {

            var viewstuff = _repo.Tasks.ToList();

            return View(viewstuff);
        }

        public IActionResult Quadrants()
        {
            var viewstuff = _repo.Tasks
                .OrderBy(x => x.TaskId).ToList();

            return View(viewstuff);
        }


        [HttpGet]
        public IActionResult AddEditTask()
        {
            ViewBag.categories = _repo.Categories.ToList();
            return View("AddEditTask", new Models.Task());
        }


        [HttpPost]
        public IActionResult AddEditTask(Models.Task task)
        {
            if (ModelState.IsValid)
            {
                _repo.AddTask(task);
                return View();
            }
            else
            {
                ViewBag.categories = _repo.Categories.ToList();
                return View(task);
            }
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var recordToEdit = _repo.Tasks
                .Single(x => x.TaskId == id);

            ViewBag.categories = _repo.Categories.ToList();

            return View("AddEditTask", recordToEdit);
        }

        [HttpPost]
        public IActionResult Edit(Models.Task updatedTask)
        {
            _repo.Edit(updatedTask);

            return RedirectToAction("Quadrants");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var taskToDelete = _repo.Tasks
                .Single(x => x.TaskId == id);

            return View("Quadrants", taskToDelete);
        }

        [HttpPost]
        public IActionResult Delete(Models.Task updatedTask)
        {
            _repo.Delete(updatedTask);

            return RedirectToAction("Quadrants");
        }





    }
}
