using _01_Query.Contract.JobExperience;
using Microsoft.AspNetCore.Mvc;

namespace ServiceHost.ViewComponents
{
    public class JobExperienceViewComponent : ViewComponent
    {
        private readonly IJobExperienceQuery _jobExperienceQuery;

        public JobExperienceViewComponent(IJobExperienceQuery jobExperienceQuery)
        {
            _jobExperienceQuery = jobExperienceQuery;
        }

        public IViewComponentResult Invoke()
        {
            var jobExperience = _jobExperienceQuery.GetList();
            return View(jobExperience);
        }
    }
}
