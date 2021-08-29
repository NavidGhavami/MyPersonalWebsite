using System.Collections.Generic;
using System.Linq;
using _0_Framework.Application;
using _0_Framework.Infrastructure;
using Microsoft.EntityFrameworkCore;
using ServiceManagement.Application.Contract.Customers;
using ServiceManagement.Domain.Customers;

namespace ServiceManagements.Infrastructure.EFCore.Repository
{
    public class CustomersRepository : RepositoryBase<long, Customers>, ICustomersRepository
    {
        private readonly ServiceContext _serviceContext;
        public CustomersRepository(ServiceContext serviceContext) : base(serviceContext)
        {
            _serviceContext = serviceContext;
        }

        public EditCustomers GetDetails(long id)
        {
            return _serviceContext.Customers.Select(x => new EditCustomers
            {
                Id = x.Id,
                CustomerName = x.CustomerName,
                LogoAlt = x.LogoAlt,
                LogoTitle = x.LogoTitle,

            }).FirstOrDefault(x => x.Id == id);
        }

        public List<CustomersViewModel> GetList()
        {
            return _serviceContext.Customers.Select(x => new CustomersViewModel
            {
                Id = x.Id,
                CustomerName = x.CustomerName,
                CustomerLogo = x.CustomerLogo,
                CreationDate = x.CreationDate.ToFarsi()

            }).ToList();
        }
    }
}
