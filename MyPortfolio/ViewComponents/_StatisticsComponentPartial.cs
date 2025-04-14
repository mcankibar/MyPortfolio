using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.ViewComponents
{
    public class _StatisticsComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
