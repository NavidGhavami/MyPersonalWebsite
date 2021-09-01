using System.Collections.Generic;
using _0_Framework.Application;

namespace ServiceManagement.Application.Contract.ClientsOpinion
{
    public interface IClientsOpinionApplication
    {
        OperationResult Create(CreateClientsOpinion command);
        OperationResult Edit(EditClientsOpinion command);
        OperationResult Remove(long id);
        OperationResult Restore(long id);
        EditClientsOpinion GetDetails(long id);
        List<ClientsOpinionViewModel> GetList();

    }
}
