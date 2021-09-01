using _01_Query.Contract.BasicInfo;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ServiceManagement.Application.Contract.ContactMe;

namespace ServiceHost.Pages
{
    public class ContactMeModel : PageModel
    {
        private readonly IBasicInfoQuery _basicInfoQuery;
        private readonly IContactMeApplication _contactMeApplication;

        public BasicInfoQueryModel BasicInfo;
        public string SuccessMessage;

        public ContactMeModel(IBasicInfoQuery basicInfoQuery, IContactMeApplication contactMeApplication)
        {
            _basicInfoQuery = basicInfoQuery;
            _contactMeApplication = contactMeApplication;
        }

        public void OnGet()
        {
            BasicInfo = _basicInfoQuery.GetBasicInformation();
        }

        public IActionResult OnPost(CreateContactMe command)
        {

            var result = _contactMeApplication.Create(command);
            return RedirectToPage("./SendMessageSuccess");
        }
    }
}
