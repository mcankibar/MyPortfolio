using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Dal.ApplicationDbContext;

namespace MyPortfolio.ViewComponents
{
    public class _ExperienceComponentPartial : ViewComponent
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = context.Experiences.ToList();

            return View(values);
        }
    }
}
