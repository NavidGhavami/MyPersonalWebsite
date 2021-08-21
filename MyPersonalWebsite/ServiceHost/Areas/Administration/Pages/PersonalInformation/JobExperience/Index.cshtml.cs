using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PersonalInfoManagement.Application.Contract.JobExperience;

namespace ServiceHost.Areas.Administration.Pages.PersonalInformation.JobExperience
{
    public class IndexModel : PageModel
    {
        [TempData]
        public string Message { get; set; }

        public List<JobExperienceViewModel> JobExperience;

        private readonly IJobExperienceApplication _jobExperienceApplication;

        public IndexModel(IJobExperienceApplication jobExperienceApplication)
        {
            _jobExperienceApplication = jobExperienceApplication;
        }

        public void OnGet()
        {
            JobExperience = _jobExperienceApplication.GetList();
        }

        public IActionResult OnGetCreate()
        {
            var command = new CreateJobExperience();
            return Partial("./Create", command);

        }

        public JsonResult OnPostCreate(CreateJobExperience command)
        {
            var result = _jobExperienceApplication.Create(command);
            return new JsonResult(result);
        }

        public IActionResult OnGetEdit(long id)
        {
            var slide = _jobExperienceApplication.GetDetails(id);
            return Partial("Edit", slide);
        }

        public JsonResult OnPostEdit(EditJobExperience command)
        {
            var result = _jobExperienceApplication.Edit(command);
            return new JsonResult(result);
        }
        public IActionResult OnGetRemove(long id)
        {
            var result = _jobExperienceApplication.Remove(id);

            if (result.IsSuccedded)
            {
                return RedirectToPage("./Index");
            }

            Message = result.Message;
            return RedirectToPage("./Index");

        }
        public IActionResult OnGetRestore(long id)
        {
            var result = _jobExperienceApplication.Restore(id);
            if (result.IsSuccedded)
            {
                return RedirectToPage("./Index");
            }

            Message = result.Message;
            return RedirectToPage("./Index");
        }
    }
}
