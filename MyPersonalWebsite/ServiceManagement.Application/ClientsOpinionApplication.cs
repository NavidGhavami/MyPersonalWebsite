using System.Collections.Generic;
using _0_Framework.Application;
using ServiceManagement.Application.Contract.ClientsOpinion;
using ServiceManagement.Domain.ClientsOpinion;

namespace ServiceManagement.Application
{
    public class ClientsOpinionApplication : IClientsOpinionApplication
    {
        private readonly IClientsOpinionRepository _clientsOpinionRepository;

        public ClientsOpinionApplication(IClientsOpinionRepository clientsOpinionRepository)
        {
            _clientsOpinionRepository = clientsOpinionRepository;
        }

        public OperationResult Create(CreateClientsOpinion command)
        {
            var operation = new OperationResult();

            var client = new ClientsOpinion(command.ClientName,command.ClientJob,command.Description);

            _clientsOpinionRepository.Create(client);
            _clientsOpinionRepository.SaveChanges();

            return operation.Succedded();
        }

        public OperationResult Edit(EditClientsOpinion command)
        {
            var operation = new OperationResult();
            var client = _clientsOpinionRepository.Get(command.Id);

            if (client == null)
            {
                return operation.Failed(ApplicationMessages.RecordNotFound);
            }



            client.Edit(command.ClientName, command.ClientJob, command.Description);

            _clientsOpinionRepository.SaveChanges();

            return operation.Succedded();
        }

        public OperationResult Remove(long id)
        {
            var operation = new OperationResult();
            var client = _clientsOpinionRepository.Get(id);

            if (client == null)
            {
                return operation.Failed(ApplicationMessages.RecordNotFound);
            }

            client.Remove();

            _clientsOpinionRepository.SaveChanges();

            return operation.Succedded();
        }

        public OperationResult Restore(long id)
        {
            var operation = new OperationResult();
            var client = _clientsOpinionRepository.Get(id);

            if (client == null)
            {
                return operation.Failed(ApplicationMessages.RecordNotFound);
            }

            client.Restore();

            _clientsOpinionRepository.SaveChanges();

            return operation.Succedded();
        }

        public EditClientsOpinion GetDetails(long id)
        {
            return _clientsOpinionRepository.GetDetails(id);
        }

        public List<ClientsOpinionViewModel> GetList()
        {
            return _clientsOpinionRepository.GetList();
        }
    }
}
