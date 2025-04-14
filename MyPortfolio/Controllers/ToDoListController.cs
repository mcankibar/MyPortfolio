using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Dal.ApplicationDbContext;
using MyPortfolio.Dal.Entities;

namespace MyPortfolio.Controllers
{
    public class ToDoListController : Controller
    {

        MyPortfolioContext context = new MyPortfolioContext();

        public IActionResult Index()
        {
            var values = context.ToDoLists.ToList();
            return View(values);
        }

        public IActionResult CreateToDo()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult CreateToDo(ToDoList toDoList)
        {
            toDoList.Status = false;
            context.ToDoLists.Add(toDoList);
            context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult DeleteToDo(int Id)
        {
            ToDoList? deletedToDo = context.ToDoLists.Find(Id);
            context.ToDoLists.Remove(deletedToDo);
            context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult UpdateToDo(int Id)
        {
            var toDo = context.ToDoLists.Find(Id);

            return View(toDo);
        }

        [HttpPost]
        public IActionResult UpdateToDo(ToDoList toDoList)
        {
            context.ToDoLists.Update(toDoList);
            context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult ChangeStatus(int Id)
        {
            var toDo = context.ToDoLists.Find(Id);
            toDo.Status = !toDo.Status;
            context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

    }
}
