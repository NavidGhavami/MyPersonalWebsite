using System.Collections.Generic;
using System.Linq;
using _01_Query.Contract.ClientsOpinion;
using ServiceManagements.Infrastructure.EFCore;

namespace _01_Query.Query
{
    public class ClientsOpinionQuery : IClientsOpinionQuery
    {
        private readonly ServiceContext _serviceContext;

        public ClientsOpinionQuery(ServiceContext serviceContext)
        {
            _serviceContext = serviceContext;
        }

        public List<ClientsOpinionQueryModel> GetClientsOpinionList()
        {
            return _serviceContext.ClientsOpinions
                .Where(x=>x.IsRemoved==false)
                .Select(x => new ClientsOpinionQueryModel
            {
                ClientName = x.ClientName,
                ClientJob = x.ClientJob,
                Description = x.Description

            }).ToList();
        }
    }
}
