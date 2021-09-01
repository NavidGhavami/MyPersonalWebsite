using System.Collections.Generic;
using System.Linq;
using _0_Framework.Application;
using _0_Framework.Infrastructure;
using Microsoft.EntityFrameworkCore;
using ServiceManagement.Application.Contract.ClientsOpinion;
using ServiceManagement.Domain.ClientsOpinion;

namespace ServiceManagements.Infrastructure.EFCore.Repository
{
    public class ClientsOpinionRepository : RepositoryBase<long, ClientsOpinion>, IClientsOpinionRepository
    {
        private readonly ServiceContext _serviceContext;
        public ClientsOpinionRepository(ServiceContext serviceContext) : base(serviceContext)
        {
            _serviceContext = serviceContext;
        }

        public EditClientsOpinion GetDetails(long id)
        {
            return _serviceContext.ClientsOpinions.Select(x => new EditClientsOpinion
            {
                Id = x.Id,
                ClientName = x.ClientName,
                ClientJob = x.ClientJob,
                Description = x.Description

            }).FirstOrDefault(x => x.Id == id);
        }

        public List<ClientsOpinionViewModel> GetList()
        {
            return _serviceContext.ClientsOpinions.Select(x => new ClientsOpinionViewModel
            {
                Id = x.Id,
                ClientName = x.ClientName,
                ClientJob = x.ClientJob,
                IsRemoved = x.IsRemoved,
                Description = x.Description,
                CreationDate = x.CreationDate.ToFarsi()

            }).ToList();
        }
    }
}
