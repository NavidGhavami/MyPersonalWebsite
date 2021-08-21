using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PersonalInfoManagement.Application.Contract.Skill;

namespace ServiceHost.Areas.Administration.Pages.PersonalInformation.Skills
{
    public class IndexModel : PageModel
    {
        [TempData]
        public string Message { get; set; }

        public List<SkillViewModel> Skills;

        private readonly ISkillApplication _skillApplication;

        public IndexModel(ISkillApplication skillApplication)
        {
            _skillApplication = skillApplication;
        }

        public void OnGet()
        {
            Skills = _skillApplication.GetList();
        }

        public IActionResult OnGetCreate()
        {
            var command = new CreateSkill();
            return Partial("./Create", command);

        }

        public JsonResult OnPostCreate(CreateSkill command)
        {
            var result = _skillApplication.Create(command);
            return new JsonResult(result);
        }

        public IActionResult OnGetEdit(long id)
        {
            var slide = _skillApplication.GetDetails(id);
            return Partial("Edit", slide);
        }

        public JsonResult OnPostEdit(EditSkill command)
        {
            var result = _skillApplication.Edit(command);
            return new JsonResult(result);
        }
        public IActionResult OnGetRemove(long id)
        {
            var result = _skillApplication.Remove(id);

            if (result.IsSuccedded)
            {
                return RedirectToPage("./Index");
            }

            Message = result.Message;
            return RedirectToPage("./Index");

        }
        public IActionResult OnGetRestore(long id)
        {
            var result = _skillApplication.Restore(id);
            if (result.IsSuccedded)
            {
                return RedirectToPage("./Index");
            }

            Message = result.Message;
            return RedirectToPage("./Index");
        }
    }
}
