using System.Collections.Generic;
using _01_Query.Contract.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Pages
{
    public class MyServicesModel : PageModel
    {
        private readonly IServiceQuery _serviceQuery;

        public List<ServicesQueryModel> Services;

        public MyServicesModel(IServiceQuery serviceQuery)
        {
            _serviceQuery = serviceQuery;
        }

        public void OnGet()
        {
            Services = _serviceQuery.GetList();
        }
    }
}
