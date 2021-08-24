using System.Collections.Generic;
using _0_Framework.Application;
using ProjectManagement.Application.Contract.ProjectCategory;
using ProjectManagement.Domain.ProjectCategory;

namespace ProjectManagement.Application
{
    public class ProjectCategoryApplication : IProjectCategoryApplication
    {
        private readonly IProjectCategoryRepository _projectCategoryRepository;

        public ProjectCategoryApplication(IProjectCategoryRepository projectCategoryRepository)
        {
            _projectCategoryRepository = projectCategoryRepository;
        }

        public OperationResult Create(CreateProjectCategory command)
        {
            var operation = new OperationResult();

            var projectCategory = new ProjectCategory(command.Name);

            _projectCategoryRepository.Create(projectCategory);
            _projectCategoryRepository.SaveChanges();

            return operation.Succedded();
        }

        public OperationResult Edit(EditProjectCategory command)
        {
            var operation = new OperationResult();
            var projectCategory = _projectCategoryRepository.Get(command.Id);

            if (projectCategory == null)
            {
                return operation.Failed(ApplicationMessages.RecordNotFound);
            }


            projectCategory.Edit(command.Name);

            _projectCategoryRepository.SaveChanges();

            return operation.Succedded();
        }

        public EditProjectCategory GetDetails(long id)
        {
            return _projectCategoryRepository.GetDetails(id);
        }

        public List<ProjectCategoryViewModel> GetProjectCategory()
        {
            return _projectCategoryRepository.GetProjectCategory();
        }
    }
}
