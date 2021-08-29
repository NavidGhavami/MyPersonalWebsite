using System.Collections.Generic;
using _01_Query.Contract.Plans;
using _01_Query.Contract.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Pages
{
    public class MyServicesModel : PageModel
    {
        private readonly IServiceQuery _serviceQuery;
        private readonly IPlansQuery _plansQuery;

        public List<ServicesQueryModel> Services;
        public List<PlansQueryModel> Plans;

        public MyServicesModel(IServiceQuery serviceQuery, IPlansQuery plansQuery)
        {
            _serviceQuery = serviceQuery;
            _plansQuery = plansQuery;
        }

        public void OnGet()
        {
            Services = _serviceQuery.GetList();
            Plans = _plansQuery.GetPlans();

        }
    }
}
