using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Dal.ApplicationDbContext;

namespace MyPortfolio.ViewComponents
{
    public class _FeatureComponentPartial : ViewComponent
    {
        MyPortfolioContext portfolioContext = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = portfolioContext.Features.ToList();

            return View(values);
        }
    }
}
