using System.Collections.Generic;
using _0_Framework.Application;

namespace ServiceManagement.Application.Contract.ContactMe
{
    public interface IContactMeApplication
    {
        OperationResult Create(CreateContactMe command);
        List<ContactMeViewModel> GetList();
        ContactMeViewModel GetInformationBy(long id);

    }
}
