using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Dal.ApplicationDbContext;

namespace MyPortfolio.ViewComponents.LayoutViewComponents
{
    public class _LayoutHeadComponentPartial : ViewComponent
    {
        
        public IViewComponentResult Invoke()
        {
            

            return View();
        }
    }
}
