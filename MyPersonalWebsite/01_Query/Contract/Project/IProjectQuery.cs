using System.Collections.Generic;

namespace _01_Query.Contract.Project
{
    public interface IProjectQuery
    {
        List<ProjectQueryModel> GetProjects();
        ProjectQueryModel GetProjectDetails(string slug);
    }
}
