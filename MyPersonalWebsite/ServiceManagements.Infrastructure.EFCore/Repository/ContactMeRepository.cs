using System.Collections.Generic;
using System.Linq;
using _0_Framework.Application;
using _0_Framework.Infrastructure;
using ServiceManagement.Application.Contract.ContactMe;
using ServiceManagement.Domain.ContactMe;

namespace ServiceManagements.Infrastructure.EFCore.Repository
{
    public class ContactMeRepository : RepositoryBase<long, ContactMe>, IContactMeRepository
    {
        private readonly ServiceContext _serviceContext;
        public ContactMeRepository(ServiceContext serviceContext) : base(serviceContext)
        {
            _serviceContext = serviceContext;
        }

        public List<ContactMeViewModel> GetList()
        {
            return _serviceContext.ContactMe.Select(x => new ContactMeViewModel
            {
                Id = x.Id,
                FullName = x.FullName,
                Email = x.Email,
                Mobile = x.Mobile,
                Message = x.Message,
                CreationDate = x.CreationDate.ToFarsi()


            }).ToList();
        }

        public ContactMeViewModel GetInformationBy(long id)
        {
            var info = _serviceContext.ContactMe.FirstOrDefault(x => x.Id == id);

            if (info == null)
            {
                return new ContactMeViewModel();
            }

            var information = new ContactMeViewModel
            {
                Id = info.Id,
                FullName = info.FullName,
                Email = info.Email,
                Mobile = info.Mobile,
                Message = info.Message

            };

            return information;

        }
    }
}
