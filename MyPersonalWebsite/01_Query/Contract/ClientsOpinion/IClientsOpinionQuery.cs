using System.Collections.Generic;

namespace _01_Query.Contract.ClientsOpinion
{
    public interface IClientsOpinionQuery
    {
        List<ClientsOpinionQueryModel> GetClientsOpinionList();
    }
}
