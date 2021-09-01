using System.Collections.Generic;
using _0_Framework.Application;
using ServiceManagement.Application.Contract.ContactMe;
using ServiceManagement.Domain.ContactMe;

namespace ServiceManagement.Application
{
    public class ContactMeApplication : IContactMeApplication
    {
        private readonly IContactMeRepository _contactMeRepository;

        public ContactMeApplication(IContactMeRepository contactMeRepository)
        {
            _contactMeRepository = contactMeRepository;
        }

        public OperationResult Create(CreateContactMe command)
        {
            var operation = new OperationResult();

            var client = new ContactMe(command.FullName,command.Email,command.Mobile,command.Message);

            _contactMeRepository.Create(client);
            _contactMeRepository.SaveChanges();

            return operation.Succedded();
        }

        public List<ContactMeViewModel> GetList()
        {
            return _contactMeRepository.GetList();
        }

        public ContactMeViewModel GetInformationBy(long id)
        {
            return _contactMeRepository.GetInformationBy(id);
        }
    }
}
