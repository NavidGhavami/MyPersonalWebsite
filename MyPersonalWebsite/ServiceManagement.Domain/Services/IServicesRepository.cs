using System.Collections.Generic;
using _0_Framework.Domain;
using ServiceManagement.Application.Contract.Services;

namespace ServiceManagement.Domain.Services
{
    public interface IServicesRepository : IRepository<long, Services>
    {
        EditServices GetDetails(long id);
        List<ServicesViewModel> GetList();
    }
}
