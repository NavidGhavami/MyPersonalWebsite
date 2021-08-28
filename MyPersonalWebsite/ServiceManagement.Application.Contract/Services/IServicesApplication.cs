using System.Collections.Generic;
using _0_Framework.Application;

namespace ServiceManagement.Application.Contract.Services
{
    public interface IServicesApplication
    {
        OperationResult Create(CreateServices command);
        OperationResult Edit(EditServices command);
        EditServices GetDetails(long id);
        List<ServicesViewModel> GetList();
    }
}
