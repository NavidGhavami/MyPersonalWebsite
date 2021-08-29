using _0_Framework.Domain;

namespace ServiceManagement.Domain.Plans
{
    public class Plans : EntityBase
    {
        public string PlanName { get; private set; }
        public string PlanPrice { get; private set; }
        public string PlanDescription1 { get; private set; }
        public string PlanDescription2 { get; private set; }
        public string PlanDescription3 { get; private set; }
        public string PlanDescription4 { get; private set; }
        public string PlanDescription5 { get; private set; }
        public string PlanDescription6 { get; private set; }
        public string PlanDescription7 { get; private set; }
        public string PlanDescription8 { get; private set; }
        public string PlanDescription9 { get; private set; }
        public string PlanDescription10 { get; private set; }


        public Plans(string planName, string planPrice, string planDescription1, string planDescription2, string planDescription3, 
            string planDescription4, string planDescription5, string planDescription6, string planDescription7, string planDescription8, 
            string planDescription9, string planDescription10)
        {
            PlanName = planName;
            PlanPrice = planPrice;
            PlanDescription1 = planDescription1;
            PlanDescription2 = planDescription2;
            PlanDescription3 = planDescription3;
            PlanDescription4 = planDescription4;
            PlanDescription5 = planDescription5;
            PlanDescription6 = planDescription6;
            PlanDescription7 = planDescription7;
            PlanDescription8 = planDescription8;
            PlanDescription9 = planDescription9;
            PlanDescription10 = planDescription10;
        }

        public void Edit(string planName, string planPrice, string planDescription1, string planDescription2, string planDescription3,
            string planDescription4, string planDescription5, string planDescription6, string planDescription7, string planDescription8,
            string planDescription9, string planDescription10)
        {
            PlanName = planName;
            PlanPrice = planPrice;
            PlanDescription1 = planDescription1;
            PlanDescription2 = planDescription2;
            PlanDescription3 = planDescription3;
            PlanDescription4 = planDescription4;
            PlanDescription5 = planDescription5;
            PlanDescription6 = planDescription6;
            PlanDescription7 = planDescription7;
            PlanDescription8 = planDescription8;
            PlanDescription9 = planDescription9;
            PlanDescription10 = planDescription10;
        }
    }
}
