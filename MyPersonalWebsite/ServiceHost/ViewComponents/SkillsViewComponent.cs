using _01_Query.Contract.Skills;
using Microsoft.AspNetCore.Mvc;

namespace ServiceHost.ViewComponents
{
    public class SkillsViewComponent : ViewComponent
    {
        private readonly ISkillQuery _skillQuery;

        public SkillsViewComponent(ISkillQuery skillQuery)
        {
            _skillQuery = skillQuery;
        }

        public IViewComponentResult Invoke()
        {
            var skill = _skillQuery.GetSkills();
            return View(skill);
        }
    }
}
