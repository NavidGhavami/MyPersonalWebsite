using System.Collections.Generic;
using System.Linq;
using _0_Framework.Application;
using _0_Framework.Infrastructure;
using Microsoft.EntityFrameworkCore;
using ServiceManagement.Application.Contract.Services;
using ServiceManagement.Domain.Services;

namespace ServiceManagements.Infrastructure.EFCore.Repository
{
    public class ServicesRepository : RepositoryBase<long, Services> , IServicesRepository
    {
        private readonly ServiceContext _serviceContext;
        public ServicesRepository(ServiceContext serviceContext) : base(serviceContext)
        {
            _serviceContext = serviceContext;
        }

        public EditServices GetDetails(long id)
        {
            return _serviceContext.Services.Select(x => new EditServices
            {
                Id = x.Id,
                ServiceName = x.ServiceName,
                ServiceLogo = x.ServiceLogo,
                ServiceDescription = x.ServiceDescription

            }).FirstOrDefault(x => x.Id == id);
        }

        public List<ServicesViewModel> GetList()
        {
            return _serviceContext.Services.Select(x => new ServicesViewModel
            {
                Id = x.Id,
                ServiceName = x.ServiceName,
                ServiceLogo = x.ServiceLogo,
                CreationDate = x.CreationDate.ToFarsi(),
                ServiceDescription = x.ServiceDescription

            }).ToList();
        }
    }
}
