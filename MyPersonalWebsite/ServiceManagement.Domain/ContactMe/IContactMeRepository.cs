using System.Collections.Generic;
using _0_Framework.Domain;
using ServiceManagement.Application.Contract.ContactMe;

namespace ServiceManagement.Domain.ContactMe
{
    public interface IContactMeRepository : IRepository<long, ContactMe>
    {
        List<ContactMeViewModel> GetList();
        ContactMeViewModel GetInformationBy(long id);

    }
}
