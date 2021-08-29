using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ServiceManagement.Application.Contract.Plans;

namespace ServiceHost.Areas.Administration.Pages.Services.Plans
{
    public class IndexModel : PageModel
    {
        [TempData]
        public string Message { get; set; }

        public List<PlansViewModel> Plans;

        private readonly IPlansApplication _plansApplication;

        public IndexModel(IPlansApplication plansApplication)
        {
            _plansApplication = plansApplication;

        }


        public void OnGet()
        {

            Plans = _plansApplication.GetList();
        }

        public IActionResult OnGetCreate()
        {
            var command = new CreatePlans();
            return Partial("./Create", command);

        }

        public JsonResult OnPostCreate(CreatePlans command)
        {
            var result = _plansApplication.Create(command);
            return new JsonResult(result);
        }

        public IActionResult OnGetEdit(long id)
        {
            var slide = _plansApplication.GetDetails(id);
            return Partial("Edit", slide);
        }

        public JsonResult OnPostEdit(EditPlans command)
        {
            var result = _plansApplication.Edit(command);
            return new JsonResult(result);
        }
    }
}
