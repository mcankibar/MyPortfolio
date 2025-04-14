using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Dal.ApplicationDbContext;
using MyPortfolio.Dal.Entities;

namespace MyPortfolio.Controllers
{
    public class MessageController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();

        public IActionResult Inbox()
        {
            var values = context.Messages.ToList(); 

            return View(values);
        }


        public IActionResult ChangeIsRead(int Id)
        {
            Message message = context.Messages.Find(Id);
            message.isRead = !message.isRead;
            context.SaveChanges();

            return RedirectToAction(nameof(Inbox));
        }

        public IActionResult DeleteMessage(int Id)
        {
            Message? message = context.Messages.Find(Id);
            context.Messages.Remove(message);
            context.SaveChanges();

            return RedirectToAction(nameof(Inbox));
        }

        public IActionResult MessageDetail(int Id)
        {
            Message? message = context.Messages.Find(Id);
            

            return View(message);
        }
    }
}
