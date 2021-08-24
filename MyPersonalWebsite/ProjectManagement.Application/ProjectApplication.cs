using System.Collections.Generic;
using _0_Framework.Application;
using ProjectManagement.Application.Contract.Project;
using ProjectManagement.Domain.Project;
using ProjectManagement.Domain.ProjectCategory;

namespace ProjectManagement.Application
{
    public class ProjectApplication : IProjectApplication
    {
        private readonly IProjectCategoryRepository _projectCategoryRepository;
        private readonly IProjectRepository _projectRepository;
        private readonly IFileUploader _fileUploader;

        public ProjectApplication(IProjectCategoryRepository projectCategoryRepository, IProjectRepository projectRepository, IFileUploader fileUploader)
        {
            _projectCategoryRepository = projectCategoryRepository;
            _projectRepository = projectRepository;
            _fileUploader = fileUploader;
        }

        public OperationResult Create(CreateProject command)
        {
            var operation = new OperationResult();
            if (_projectRepository.Exist(x => x.Name == command.Name))
            {
                return operation.Failed(ApplicationMessages.DuplicatedRecord);
            }
            var slug = command.Slug.Slugify();
            var picturePath = $"{"Project"}/{slug}";

            var firstPicture= _fileUploader.Upload(command.FirstPicture, picturePath);
            var secondPicture= _fileUploader.Upload(command.SecondPicture, picturePath);
            var thirdPicture= _fileUploader.Upload(command.ThirdPicture, picturePath);
            var forthPicture= _fileUploader.Upload(command.ForthPicture, picturePath);

            var project = new Project(command.Name,command.Customer,command.Technology,firstPicture,secondPicture,thirdPicture,forthPicture,
                command.PictureAlt,command.PictureTitle,command.Slug,command.UrlLink,command.CategoryId,command.Description);

            _projectRepository.Create(project);
            _projectRepository.SaveChanges();

            return operation.Succedded();
        }

        public OperationResult Edit(EditProject command)
        {
            var operation = new OperationResult();
            var project = _projectRepository.GetProjectWithCategory(command.Id);
            if (project == null)
            {
                return operation.Failed(ApplicationMessages.RecordNotFound);
            }

            if (_projectRepository.Exist(x => x.Name == command.Name && x.Id != command.Id))
            {
                return operation.Failed(ApplicationMessages.DuplicatedRecord);
            }
            var slug = command.Slug.Slugify();
            var picturePath = $"{"Project"}/{slug}";

            var firstPicture = _fileUploader.Upload(command.FirstPicture, picturePath);
            var secondPicture = _fileUploader.Upload(command.SecondPicture, picturePath);
            var thirdPicture = _fileUploader.Upload(command.ThirdPicture, picturePath);
            var forthPicture = _fileUploader.Upload(command.ForthPicture, picturePath);

            project.Edit(command.Name, command.Customer, command.Technology, firstPicture, secondPicture, thirdPicture, forthPicture,
                command.PictureAlt, command.PictureTitle, command.Slug, command.UrlLink, command.CategoryId, command.Description);

            _projectRepository.SaveChanges();

            return operation.Succedded();
        }

        public EditProject GetDetails(long id)
        {
            return _projectRepository.GetDetails(id);
        }

        public List<ProjectViewModel> GetProjects()
        {
            return _projectRepository.GetProjects();
        }
    }
}
