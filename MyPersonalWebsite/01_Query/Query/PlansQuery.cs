using System.Collections.Generic;
using System.Linq;
using _01_Query.Contract.Plans;
using ServiceManagements.Infrastructure.EFCore;

namespace _01_Query.Query
{
    public class PlansQuery : IPlansQuery
    {
        private readonly ServiceContext _serviceContext;

        public PlansQuery(ServiceContext serviceContext)
        {
            _serviceContext = serviceContext;
        }

        public List<PlansQueryModel> GetPlans()
        {
            return _serviceContext.Plans
                    .Select(x => new PlansQueryModel
                    {
                        PlanName = x.PlanName,
                        PlanPrice = x.PlanPrice,
                        PlanDescription1 = x.PlanDescription1,
                        PlanDescription2 = x.PlanDescription2,
                        PlanDescription3 = x.PlanDescription3,
                        PlanDescription4 = x.PlanDescription4,
                        PlanDescription5 = x.PlanDescription5,
                        PlanDescription6 = x.PlanDescription6,
                        PlanDescription7 = x.PlanDescription7,
                        PlanDescription8 = x.PlanDescription8,
                        PlanDescription9 = x.PlanDescription9,
                        PlanDescription10 = x.PlanDescription10


                    }).ToList();
        }
    }
}

