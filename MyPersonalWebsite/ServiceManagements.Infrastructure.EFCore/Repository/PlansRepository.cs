using System.Collections.Generic;
using System.Linq;
using _0_Framework.Application;
using _0_Framework.Infrastructure;
using Microsoft.EntityFrameworkCore;
using ServiceManagement.Application.Contract.Plans;
using ServiceManagement.Domain.Plans;

namespace ServiceManagements.Infrastructure.EFCore.Repository
{
    public class PlansRepository : RepositoryBase<long,Plans>, IPlansRepository
    {
        private readonly ServiceContext _serviceContext;
        public PlansRepository(ServiceContext serviceContext) : base(serviceContext)
        {
            _serviceContext = serviceContext;
        }

        public EditPlans GetDetails(long id)
        {
            return _serviceContext.Plans.Select(x => new EditPlans
            {

                Id = x.Id,
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

            }).FirstOrDefault(x => x.Id == id);
        }

        public List<PlansViewModel> GetList()
        {
            return _serviceContext.Plans.Select(x => new PlansViewModel
            {
                Id = x.Id,
                PlanName = x.PlanName,
                PlanPrice = x.PlanPrice,
                CreationDate = x.CreationDate.ToFarsi()

            }).ToList();
        }
    }
}
