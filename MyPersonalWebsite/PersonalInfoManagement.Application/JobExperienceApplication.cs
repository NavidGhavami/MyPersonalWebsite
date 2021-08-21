using System.Collections.Generic;
using _0_Framework.Application;
using PersonalInfo.Domain.JobExperience;
using PersonalInfoManagement.Application.Contract.JobExperience;

namespace PersonalInfoManagement.Application
{
    public class JobExperienceApplication : IJobExperienceApplication
    {
        private readonly IJobExperienceRepository _jobExperienceRepository;

        public JobExperienceApplication(IJobExperienceRepository jobExperienceRepository)
        {
            _jobExperienceRepository = jobExperienceRepository;
        }

        public OperationResult Create(CreateJobExperience command)
        {
            var operation = new OperationResult();

            var jobExperience = new JobExperience(command.CompanyName,command.JobPosition,command.WorkDate,command.Description);

            _jobExperienceRepository.Create(jobExperience);
            _jobExperienceRepository.SaveChanges();

            return operation.Succedded();
        }

        public OperationResult Edit(EditJobExperience command)
        {
            var operation = new OperationResult();
            var jobExperience = _jobExperienceRepository.Get(command.Id);

            if (jobExperience == null)
            {
                return operation.Failed(ApplicationMessages.RecordNotFound);
            }


            jobExperience.Edit(command.CompanyName, command.JobPosition, command.WorkDate, command.Description);

            _jobExperienceRepository.SaveChanges();

            return operation.Succedded();
        }

        public OperationResult Remove(long id)
        {
            var operation = new OperationResult();
            var jobExperience = _jobExperienceRepository.Get(id);

            if (jobExperience == null)
            {
                return operation.Failed(ApplicationMessages.RecordNotFound);
            }

            jobExperience.Remove();

            _jobExperienceRepository.SaveChanges();

            return operation.Succedded();
        }

        public OperationResult Restore(long id)
        {
            var operation = new OperationResult();
            var jobExperience = _jobExperienceRepository.Get(id);

            if (jobExperience == null)
            {
                return operation.Failed(ApplicationMessages.RecordNotFound);
            }

            jobExperience.Restore();

            _jobExperienceRepository.SaveChanges();

            return operation.Succedded();
        }

        public EditJobExperience GetDetails(long id)
        {
            return _jobExperienceRepository.GetDetails(id);
        }

        public List<JobExperienceViewModel> GetList()
        {
            return _jobExperienceRepository.GetList();
        }
    }
}
