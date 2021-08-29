using System.Collections.Generic;

namespace _01_Query.Contract.Customers
{
    public interface ICustomersQuery
    {
        List<CustomersQueryModel> GetCustomers();
    }
}
