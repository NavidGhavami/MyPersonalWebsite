using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ServiceManagement.Application.Contract.Customers;

namespace ServiceHost.Areas.Administration.Pages.Services.Customers
{
    public class IndexModel : PageModel
    {
        [TempData]
        public string Message { get; set; }

        public List<CustomersViewModel> Customers;

        private readonly ICustomersApplication _customersApplication;

        public IndexModel(ICustomersApplication customersApplication)
        {
            _customersApplication = customersApplication;

        }


        public void OnGet()
        {

            Customers = _customersApplication.GetList();
        }

        public IActionResult OnGetCreate()
        {
            var command = new CreateCustomers();
            return Partial("./Create", command);

        }

        public JsonResult OnPostCreate(CreateCustomers command)
        {
            var result = _customersApplication.Create(command);
            return new JsonResult(result);
        }

        public IActionResult OnGetEdit(long id)
        {
            var slide = _customersApplication.GetDetails(id);
            return Partial("Edit", slide);
        }

        public JsonResult OnPostEdit(EditCustomers command)
        {
            var result = _customersApplication.Edit(command);
            return new JsonResult(result);
        }
    }
}
