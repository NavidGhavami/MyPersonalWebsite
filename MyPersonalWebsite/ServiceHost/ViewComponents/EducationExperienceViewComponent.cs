using _01_Query.Contract.EducationExperience;
using Microsoft.AspNetCore.Mvc;

namespace ServiceHost.ViewComponents
{
    public class EducationExperienceViewComponent : ViewComponent
    {
        private readonly IEducationExperienceQuery _educationExperienceQuery;

        public EducationExperienceViewComponent(IEducationExperienceQuery educationExperienceQuery)
        {
            _educationExperienceQuery = educationExperienceQuery;
        }

        public IViewComponentResult Invoke()
        {
            var educationExperience = _educationExperienceQuery.GetList();
            return View(educationExperience);
        }
    }
}
