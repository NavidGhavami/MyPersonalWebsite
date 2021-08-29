using System.Collections.Generic;
using _0_Framework.Application;

namespace ServiceManagement.Application.Contract.Customers
{
    public interface ICustomersApplication
    {
        OperationResult Create(CreateCustomers command);
        OperationResult Edit(EditCustomers command);
        EditCustomers GetDetails(long id);
        List<CustomersViewModel> GetList();
    }
}
