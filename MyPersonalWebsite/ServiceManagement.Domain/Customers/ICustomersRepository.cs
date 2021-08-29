using System.Collections.Generic;
using _0_Framework.Domain;
using ServiceManagement.Application.Contract.Customers;

namespace ServiceManagement.Domain.Customers
{
    public interface ICustomersRepository : IRepository<long, Customers>
    {
        EditCustomers GetDetails(long id);
        List<CustomersViewModel> GetList();
    }
}
