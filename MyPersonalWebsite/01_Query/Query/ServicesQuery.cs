using System.Collections.Generic;
using System.Linq;
using _01_Query.Contract.Services;
using Microsoft.Extensions.DependencyInjection;
using ServiceManagements.Infrastructure.EFCore;

namespace _01_Query.Query
{
    public class ServicesQuery : IServiceQuery
    {
        private readonly ServiceContext _serviceContext;

        public ServicesQuery(ServiceContext serviceContext)
        {
            _serviceContext = serviceContext;
        }

        public List<ServicesQueryModel> GetList()
        {
            return _serviceContext.Services.Select(x => new ServicesQueryModel
            {
                ServiceName = x.ServiceName,
                ServiceLogo = x.ServiceLogo,
                ServiceDescription = x.ServiceDescription

            }).ToList();
        }
    }
}
