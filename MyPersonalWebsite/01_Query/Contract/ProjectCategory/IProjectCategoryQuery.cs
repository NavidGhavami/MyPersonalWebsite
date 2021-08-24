using System.Collections.Generic;

namespace _01_Query.Contract.ProjectCategory
{
    public interface IProjectCategoryQuery
    {
        List<ProjectCategoryQueryModel> GetProjectCategories();
    }
}
