using System.ComponentModel.DataAnnotations;
using _0_Framework.Application;

namespace ServiceManagement.Application.Contract.Plans
{
    public class CreatePlans
    {

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string PlanName { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string PlanPrice { get; set; }
        public string PlanDescription1 { get; set; }
        public string PlanDescription2 { get; set; }
        public string PlanDescription3 { get; set; }
        public string PlanDescription4 { get; set; }
        public string PlanDescription5 { get; set; }
        public string PlanDescription6 { get; set; }
        public string PlanDescription7 { get; set; }
        public string PlanDescription8 { get; set; }
        public string PlanDescription9 { get; set; }
        public string PlanDescription10 { get; set; }

    }
}
