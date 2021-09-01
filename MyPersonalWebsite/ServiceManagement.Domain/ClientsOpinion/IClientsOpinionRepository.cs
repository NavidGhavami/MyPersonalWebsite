using System.Collections.Generic;
using _0_Framework.Domain;
using ServiceManagement.Application.Contract.ClientsOpinion;

namespace ServiceManagement.Domain.ClientsOpinion
{
    public interface IClientsOpinionRepository : IRepository<long, ClientsOpinion>
    {
        EditClientsOpinion GetDetails(long id);
        List<ClientsOpinionViewModel> GetList();
    }
}
