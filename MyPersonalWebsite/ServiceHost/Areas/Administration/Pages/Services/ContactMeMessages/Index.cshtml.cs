using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ServiceManagement.Application.Contract.ContactMe;

namespace ServiceHost.Areas.Administration.Pages.Services.ContactMeMessages
{
    public class IndexModel : PageModel
    {
        [TempData]
        public string Message { get; set; }

        public List<ContactMeViewModel> ContactMe;

        private readonly IContactMeApplication _contactMeApplication;

        public IndexModel(IContactMeApplication contactMeApplication)
        {
            _contactMeApplication = contactMeApplication;

        }


        public void OnGet()
        {

            ContactMe = _contactMeApplication.GetList();
        }

        public IActionResult OnGetGetInformation(long id)
        {
            var info = _contactMeApplication.GetInformationBy(id);
            return Partial("ShowInformation", info);
        }






    }
}
