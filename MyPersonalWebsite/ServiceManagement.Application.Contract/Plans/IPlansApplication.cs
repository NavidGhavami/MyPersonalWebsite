using System.Collections.Generic;
using _0_Framework.Application;

namespace ServiceManagement.Application.Contract.Plans
{
    public interface IPlansApplication
    {
        OperationResult Create(CreatePlans command);
        OperationResult Edit(EditPlans command);
        EditPlans GetDetails(long id);
        List<PlansViewModel> GetList();
    }
}
