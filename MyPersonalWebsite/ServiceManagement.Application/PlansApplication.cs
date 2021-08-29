using System.Collections.Generic;
using _0_Framework.Application;
using ServiceManagement.Application.Contract.Plans;
using ServiceManagement.Domain.Plans;

namespace ServiceManagement.Application
{
    public class PlansApplication : IPlansApplication
    {
        private readonly IPlansRepository _plansRepository;

        public PlansApplication(IPlansRepository plansRepository)
        {
            _plansRepository = plansRepository;
        }

        public OperationResult Create(CreatePlans command)
        {
            var operation = new OperationResult();

            var plan = new Plans(command.PlanName, command.PlanPrice, command.PlanDescription1, command.PlanDescription2, command.PlanDescription3,
                command.PlanDescription4, command.PlanDescription5, command.PlanDescription6, command.PlanDescription7,
                command.PlanDescription8, command.PlanDescription9, command.PlanDescription10);

            _plansRepository.Create(plan);
            _plansRepository.SaveChanges();

            return operation.Succedded();
        }

        public OperationResult Edit(EditPlans command)
        {
            var operation = new OperationResult();
            var plan = _plansRepository.Get(command.Id);

            if (plan == null)
            {
                return operation.Failed(ApplicationMessages.RecordNotFound);
            }



            plan.Edit(command.PlanName, command.PlanPrice, command.PlanDescription1, command.PlanDescription2, command.PlanDescription3,
                command.PlanDescription4, command.PlanDescription5, command.PlanDescription6, command.PlanDescription7,
                command.PlanDescription8, command.PlanDescription9, command.PlanDescription10);

            _plansRepository.SaveChanges();

            return operation.Succedded();
        }

        public EditPlans GetDetails(long id)
        {
            return _plansRepository.GetDetails(id);
        }

        public List<PlansViewModel> GetList()
        {
            return _plansRepository.GetList();
        }
    }
}
