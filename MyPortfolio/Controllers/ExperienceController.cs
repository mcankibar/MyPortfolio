using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Dal.ApplicationDbContext;
using MyPortfolio.Dal.Entities;

namespace MyPortfolio.Controllers
{
    public class ExperienceController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IActionResult ExperienceList()
        {
            var values = context.Experiences.ToList();
            return View(values);
        }

        public IActionResult CreateExperience()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult CreateExperience(Experience experience)
        {
            context.Experiences.Add(experience);
            context.SaveChanges();

            return RedirectToAction(nameof(ExperienceList));
        }

        
        public IActionResult DeleteExperience(int Id)
        {
            Experience? deletedExperience = context.Experiences.Find(Id);
            context.Experiences.Remove(deletedExperience);
            context.SaveChanges();

            return RedirectToAction(nameof(ExperienceList));
        }

        public IActionResult UpdateExperience(int Id)
        {
            var selectedExperience = context.Experiences.Find(Id);

            return View(selectedExperience);
        }

        [HttpPost]
        public IActionResult UpdateExperience(Experience experience)
        {
            //Experience? updatedExperience = context.Experiences.Find(experience.Id);
            //updatedExperience.Title = experience.Title;
            //updatedExperience.Description = experience.Description;
            //updatedExperience.Head  = experience.Head;
            //updatedExperience.Date  = experience.Date;

            context.Experiences.Update(experience);
            context.SaveChanges();

            return RedirectToAction(nameof(ExperienceList));
        }
    }
}
