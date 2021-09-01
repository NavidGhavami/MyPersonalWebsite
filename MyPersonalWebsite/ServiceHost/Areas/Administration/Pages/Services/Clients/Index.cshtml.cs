using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ServiceManagement.Application.Contract.ClientsOpinion;

namespace ServiceHost.Areas.Administration.Pages.Services.Clients
{
    public class IndexModel : PageModel
    {
        [TempData]
        public string Message { get; set; }

        public List<ClientsOpinionViewModel> ClientsOpinion;

        private readonly IClientsOpinionApplication _clientsOpinionApplication;

        public IndexModel(IClientsOpinionApplication clientsOpinionApplication)
        {
            _clientsOpinionApplication = clientsOpinionApplication;

        }


        public void OnGet()
        {

            ClientsOpinion = _clientsOpinionApplication.GetList();
        }

        public IActionResult OnGetCreate()
        {
            var command = new CreateClientsOpinion();
            return Partial("./Create", command);

        }

        public JsonResult OnPostCreate(CreateClientsOpinion command)
        {
            var result = _clientsOpinionApplication.Create(command);
            return new JsonResult(result);
        }

        public IActionResult OnGetEdit(long id)
        {
            var slide = _clientsOpinionApplication.GetDetails(id);
            return Partial("Edit", slide);
        }

        public JsonResult OnPostEdit(EditClientsOpinion command)
        {
            var result = _clientsOpinionApplication.Edit(command);
            return new JsonResult(result);
        }


        public IActionResult OnGetRemove(long id)
        {
            var result = _clientsOpinionApplication.Remove(id);

            if (result.IsSuccedded)
            {
                return RedirectToPage("./Index");
            }

            Message = result.Message;
            return RedirectToPage("./Index");

        }
        public IActionResult OnGetRestore(long id)
        {
            var result = _clientsOpinionApplication.Restore(id);
            if (result.IsSuccedded)
            {
                return RedirectToPage("./Index");
            }

            Message = result.Message;
            return RedirectToPage("./Index");
        }
    }
}
