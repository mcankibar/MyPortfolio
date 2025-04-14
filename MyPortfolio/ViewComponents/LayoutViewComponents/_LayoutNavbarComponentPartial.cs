using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Dal.ApplicationDbContext;

namespace MyPortfolio.ViewComponents.LayoutViewComponents
{
    public class _LayoutNavbarComponentPartial : ViewComponent
    {

        MyPortfolioContext context = new MyPortfolioContext();

        public IViewComponentResult Invoke()
        {

            var values = context.ToDoLists.Where(x => x.Status == false).ToList();

            return View(values);
        }
    }
}
