using System.Collections.Generic;
using _0_Framework.Application;
using PersonalInfo.Domain.EducationExperience;
using PersonalInfoManagement.Application.Contract.EducationExperience;

namespace PersonalInfoManagement.Application
{
    public class EducationExperienceApplication : IEducationExperienceApplication
    {
        private readonly IEducationExperienceRepository _educationExperienceRepository;

        public EducationExperienceApplication(IEducationExperienceRepository educationExperienceRepository)
        {
            _educationExperienceRepository = educationExperienceRepository;
        }

        public OperationResult Create(CreateEducationExperience command)
        {
            var operation = new OperationResult();

            var educationExperience = new EducationExperience(command.UniversityName,command.EducationDegree,command.EducationCourse,command.EducationDate,command.Description);

            _educationExperienceRepository.Create(educationExperience);
            _educationExperienceRepository.SaveChanges();

            return operation.Succedded();
        }

        public OperationResult Edit(EditEducationExperience command)
        {
            var operation = new OperationResult();
            var educationExperience = _educationExperienceRepository.Get(command.Id);

            if (educationExperience == null)
            {
                return operation.Failed(ApplicationMessages.RecordNotFound);
            }


            educationExperience.Edit(command.UniversityName, command.EducationDegree, command.EducationCourse, command.EducationDate, command.Description);

            _educationExperienceRepository.SaveChanges();

            return operation.Succedded();
        }

        public OperationResult Remove(long id)
        {
            var operation = new OperationResult();
            var educationExperience = _educationExperienceRepository.Get(id);

            if (educationExperience == null)
            {
                return operation.Failed(ApplicationMessages.RecordNotFound);
            }

            educationExperience.Remove();

            _educationExperienceRepository.SaveChanges();

            return operation.Succedded();
        }

        public OperationResult Restore(long id)
        {
            var operation = new OperationResult();
            var educationExperience = _educationExperienceRepository.Get(id);

            if (educationExperience == null)
            {
                return operation.Failed(ApplicationMessages.RecordNotFound);
            }

            educationExperience.Restore();

            _educationExperienceRepository.SaveChanges();

            return operation.Succedded();
        }

        public EditEducationExperience GetDetails(long id)
        {
            return _educationExperienceRepository.GetDetails(id);
        }

        public List<EducationExperienceViewModel> GetList()
        {
            return _educationExperienceRepository.GetList();
        }
    }
}
