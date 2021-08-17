using System.Collections.Generic;
using _0_Framework.Application;

namespace PersonalInfoManagement.Application.Contract.BasicInfo
{
    public interface IBasicInfoApplication
    {
        OperationResult Create(CreateBasicInfo command);
        OperationResult Edit(EditBasicInfo command);
        EditBasicInfo GetDetails(long id);
        List<BasicInfoViewModel> GetList();
    }
}
