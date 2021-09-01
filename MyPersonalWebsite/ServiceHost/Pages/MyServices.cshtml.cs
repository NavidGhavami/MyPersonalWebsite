using System.Collections.Generic;
using _01_Query.Contract.ClientsOpinion;
using _01_Query.Contract.Customers;
using _01_Query.Contract.Plans;
using _01_Query.Contract.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Pages
{
    public class MyServicesModel : PageModel
    {
        private readonly IClientsOpinionQuery _clientsOpinionQuery;
        private readonly ICustomersQuery _customersQuery;
        private readonly IServiceQuery _serviceQuery;
        private readonly IPlansQuery _plansQuery;

        public List<ClientsOpinionQueryModel> ClientsOpinion;
        public List<CustomersQueryModel> Customers;
        public List<ServicesQueryModel> Services;
        public List<PlansQueryModel> Plans;

        public MyServicesModel(IServiceQuery serviceQuery, IPlansQuery plansQuery, ICustomersQuery customersQuery, IClientsOpinionQuery clientsOpinionQuery)
        {
            _clientsOpinionQuery = clientsOpinionQuery;
            _customersQuery = customersQuery;
            _serviceQuery = serviceQuery;
            _plansQuery = plansQuery;
        }

        public void OnGet()
        {
            ClientsOpinion = _clientsOpinionQuery.GetClientsOpinionList();
            Customers = _customersQuery.GetCustomers();
            Services = _serviceQuery.GetList();
            Plans = _plansQuery.GetPlans();

        }
    }
}
