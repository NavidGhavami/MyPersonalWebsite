using System.Collections.Generic;

namespace _01_Query.Contract.Plans
{
    public interface IPlansQuery
    {
        List<PlansQueryModel> GetPlans();
    }
}
