using AccountManagement.Application.Contract.Account;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Pages
{
    public class AccountModel : PageModel
    {
        [TempData]
        public string LoginMessage { get; set; }

        [TempData]
        public string RegisterMessage { get; set; }

        private readonly IAccountApplication _accountApplication;

        public AccountModel(IAccountApplication accountApplication)
        {
            _accountApplication = accountApplication;
        }

        public void OnGet()
        {
        }

        public IActionResult OnPost(Login command)
        {
            var result = _accountApplication.Login(command);


            if (result.IsSuccedded)
            {
                return RedirectToPage("./Index");
            }

            LoginMessage = result.Message;
            return RedirectToPage("/FailedLogin");

        }
        public IActionResult OnGetLogout(Login command)
        {
            _accountApplication.Logout();
            return RedirectToPage("./Index");
        }
    }
}
