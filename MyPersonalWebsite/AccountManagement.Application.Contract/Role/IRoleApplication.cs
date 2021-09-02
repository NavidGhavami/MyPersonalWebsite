using System.Collections.Generic;
using _0_Framework.Application;

namespace AccountManagement.Application.Contract.Role
{
    public interface IRoleApplication
    {
        OperationResult CreateRole(CreateRole command);
        OperationResult EditRole(EditRole command);
        EditRole GetDetails(long id);
        List<RoleViewModel> List();
    }
}
