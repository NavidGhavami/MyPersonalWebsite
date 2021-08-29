using System.Collections.Generic;
using System.Linq;
using _01_Query.Contract.Customers;
using ServiceManagements.Infrastructure.EFCore;

namespace _01_Query.Query
{
    public class CustomersQuery : ICustomersQuery
    {
        private readonly ServiceContext _serviceContext;

        public CustomersQuery(ServiceContext serviceContext)
        {
            _serviceContext = serviceContext;
        }

        public List<CustomersQueryModel> GetCustomers()
        {
            return _serviceContext.Customers.Select(x => new CustomersQueryModel
            {
                Id = x.Id,
                CustomerName = x.CustomerName,
                CustomerLogo = x.CustomerLogo,
                LogoAlt = x.LogoAlt,
                LogoTitle = x.LogoTitle

            }).OrderByDescending(x=>x.Id).ToList();
        }
    }
}
