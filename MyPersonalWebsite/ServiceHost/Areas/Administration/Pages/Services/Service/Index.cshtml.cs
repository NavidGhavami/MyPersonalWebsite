using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ServiceManagement.Application.Contract.Services;

namespace ServiceHost.Areas.Administration.Pages.Services.Service
{
    public class IndexModel : PageModel
    {
        [TempData]
        public string Message { get; set; }

        public List<ServicesViewModel> Services;

        private readonly IServicesApplication _servicesApplication;

        public IndexModel(IServicesApplication servicesApplication)
        {
            _servicesApplication = servicesApplication;

        }


        public void OnGet()
        {

            Services = _servicesApplication.GetList();
        }

        public IActionResult OnGetCreate()
        {
            var command = new CreateServices();
            return Partial("./Create", command);

        }

        public JsonResult OnPostCreate(CreateServices command)
        {
            var result = _servicesApplication.Create(command);
            return new JsonResult(result);
        }

        public IActionResult OnGetEdit(long id)
        {
            var slide = _servicesApplication.GetDetails(id);
            return Partial("Edit", slide);
        }

        public JsonResult OnPostEdit(EditServices command)
        {
            var result = _servicesApplication.Edit(command);
            return new JsonResult(result);
        }
    }
}
