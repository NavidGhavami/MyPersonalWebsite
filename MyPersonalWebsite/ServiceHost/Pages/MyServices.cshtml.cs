using System.Collections.Generic;
using _01_Query.Contract.Customers;
using _01_Query.Contract.Plans;
using _01_Query.Contract.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Pages
{
    public class MyServicesModel : PageModel
    {
        private readonly ICustomersQuery _customersQuery;
        private readonly IServiceQuery _serviceQuery;
        private readonly IPlansQuery _plansQuery;

        public List<CustomersQueryModel> Customers;
        public List<ServicesQueryModel> Services;
        public List<PlansQueryModel> Plans;

        public MyServicesModel(IServiceQuery serviceQuery, IPlansQuery plansQuery, ICustomersQuery customersQuery)
        {
            _customersQuery = customersQuery;
            _serviceQuery = serviceQuery;
            _plansQuery = plansQuery;
        }

        public void OnGet()
        {
            Customers = _customersQuery.GetCustomers();
            Services = _serviceQuery.GetList();
            Plans = _plansQuery.GetPlans();

        }
    }
}
