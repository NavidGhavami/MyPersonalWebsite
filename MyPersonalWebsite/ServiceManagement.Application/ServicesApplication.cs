using System.Collections.Generic;
using _0_Framework.Application;
using ServiceManagement.Application.Contract.Services;
using ServiceManagement.Domain.Services;

namespace ServiceManagement.Application
{
    public class ServicesApplication : IServicesApplication
    {
        private readonly IServicesRepository _servicesRepository;

        public ServicesApplication(IServicesRepository servicesRepository)
        {
            _servicesRepository = servicesRepository;
        }

        public OperationResult Create(CreateServices command)
        {
            var operation = new OperationResult();

            var service = new Services(command.ServiceName, command.ServiceLogo, command.ServiceDescription);

            _servicesRepository.Create(service);
            _servicesRepository.SaveChanges();

            return operation.Succedded();
        }

        public OperationResult Edit(EditServices command)
        {
            var operation = new OperationResult();
            var service = _servicesRepository.Get(command.Id);

            if (service == null)
            {
                return operation.Failed(ApplicationMessages.RecordNotFound);
            }



            service.Edit(command.ServiceName, command.ServiceLogo, command.ServiceDescription);

            _servicesRepository.SaveChanges();

            return operation.Succedded();
        }

        public EditServices GetDetails(long id)
        {
            return _servicesRepository.GetDetails(id);
        }

        public List<ServicesViewModel> GetList()
        {
            return _servicesRepository.GetList();
        }
    }
}
