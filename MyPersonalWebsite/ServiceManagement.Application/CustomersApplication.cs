using System.Collections.Generic;
using _0_Framework.Application;
using ServiceManagement.Application.Contract.Customers;
using ServiceManagement.Domain.Customers;

namespace ServiceManagement.Application
{
    public class CustomersApplication : ICustomersApplication
    {
        private readonly ICustomersRepository _customersRepository;
        private readonly IFileUploader _fileUploader;

        public CustomersApplication(ICustomersRepository customersRepository, IFileUploader fileUploader)
        {
            _customersRepository = customersRepository;
            _fileUploader = fileUploader;
        }

        public OperationResult Create(CreateCustomers command)
        {
            var operation = new OperationResult();

            var picturePath = $"Customers";
            var fileName = _fileUploader.Upload(command.CustomerLogo, picturePath);

            var customer = new Customers(command.CustomerName,fileName,command.LogoAlt,command.LogoTitle);

            _customersRepository.Create(customer);
            _customersRepository.SaveChanges();

            return operation.Succedded();
        }

        public OperationResult Edit(EditCustomers command)
        {
            var operation = new OperationResult();
            var customer = _customersRepository.Get(command.Id);

            if (customer == null)
            {
                return operation.Failed(ApplicationMessages.RecordNotFound);
            }

            var picturePath = $"Customers";
            var fileName = _fileUploader.Upload(command.CustomerLogo, picturePath);


            customer.Edit(command.CustomerName, fileName, command.LogoAlt, command.LogoTitle);

            _customersRepository.SaveChanges();

            return operation.Succedded();
        }

        public EditCustomers GetDetails(long id)
        {
            return _customersRepository.GetDetails(id);
        }

        public List<CustomersViewModel> GetList()
        {
            return _customersRepository.GetList();
        }
    }
}
