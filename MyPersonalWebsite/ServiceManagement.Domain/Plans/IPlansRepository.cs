using System.Collections.Generic;
using _0_Framework.Domain;
using ServiceManagement.Application.Contract.Plans;

namespace ServiceManagement.Domain.Plans
{
    public interface IPlansRepository : IRepository<long, Plans>
    {
        EditPlans GetDetails(long id);
        List<PlansViewModel> GetList();
    }
}
