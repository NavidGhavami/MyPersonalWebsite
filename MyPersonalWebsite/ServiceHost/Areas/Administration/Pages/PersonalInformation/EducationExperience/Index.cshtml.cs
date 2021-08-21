using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PersonalInfoManagement.Application.Contract.EducationExperience;

namespace ServiceHost.Areas.Administration.Pages.PersonalInformation.EducationExperience
{
    public class IndexModel : PageModel
    {
        [TempData]
        public string Message { get; set; }

        public List<EducationExperienceViewModel> EducationExperience;

        private readonly IEducationExperienceApplication _educationExperienceApplication;

        public IndexModel(IEducationExperienceApplication educationExperienceApplication)
        {
            _educationExperienceApplication = educationExperienceApplication;
        }

        public void OnGet()
        {
            EducationExperience = _educationExperienceApplication.GetList();
        }

        public IActionResult OnGetCreate()
        {
            var command = new CreateEducationExperience();
            return Partial("./Create", command);

        }

        public JsonResult OnPostCreate(CreateEducationExperience command)
        {
            var result = _educationExperienceApplication.Create(command);
            return new JsonResult(result);
        }

        public IActionResult OnGetEdit(long id)
        {
            var slide = _educationExperienceApplication.GetDetails(id);
            return Partial("Edit", slide);
        }

        public JsonResult OnPostEdit(EditEducationExperience command)
        {
            var result = _educationExperienceApplication.Edit(command);
            return new JsonResult(result);
        }
        public IActionResult OnGetRemove(long id)
        {
            var result = _educationExperienceApplication.Remove(id);

            if (result.IsSuccedded)
            {
                return RedirectToPage("./Index");
            }

            Message = result.Message;
            return RedirectToPage("./Index");

        }
        public IActionResult OnGetRestore(long id)
        {
            var result = _educationExperienceApplication.Restore(id);
            if (result.IsSuccedded)
            {
                return RedirectToPage("./Index");
            }

            Message = result.Message;
            return RedirectToPage("./Index");
        }
    }
}
