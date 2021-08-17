using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PersonalInfoManagement.Application.Contract.BasicInfo;

namespace ServiceHost.Areas.Administration.Pages.PersonalInformation.BasicInfo
{
    public class IndexModel : PageModel
    {
        [TempData]
        public string Message { get; set; }

        public List<BasicInfoViewModel> BasicInfo;

        private readonly IBasicInfoApplication _basicInfoApplication;

        public IndexModel(IBasicInfoApplication basicInfoApplication)
        {
            _basicInfoApplication = basicInfoApplication;

        }


        public void OnGet()
        {

            BasicInfo = _basicInfoApplication.GetList();
        }

        public IActionResult OnGetCreate()
        {
            var command = new CreateBasicInfo();
            return Partial("./Create", command);

        }

        public JsonResult OnPostCreate(CreateBasicInfo command)
        {
            var result = _basicInfoApplication.Create(command);
            return new JsonResult(result);
        }

        public IActionResult OnGetEdit(long id)
        {
            var slide = _basicInfoApplication.GetDetails(id);
            return Partial("Edit", slide);
        }

        public JsonResult OnPostEdit(EditBasicInfo command)
        {
            var result = _basicInfoApplication.Edit(command);
            return new JsonResult(result);
        }

    }
}
