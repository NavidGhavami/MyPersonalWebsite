using System.Collections.Generic;
using _0_Framework.Application;
using PersonalInfo.Domain.BasicInformation;
using PersonalInfoManagement.Application.Contract.BasicInfo;

namespace PersonalInfoManagement.Application
{
    public class BasicInfoApplication : IBasicInfoApplication
    {

        private readonly IBasicInfoRepository _basicInfoRepository;
        private readonly IFileUploader _fileUploader;
        public BasicInfoApplication(IBasicInfoRepository basicInfoRepository, IFileUploader fileUploader)
        {
            _basicInfoRepository = basicInfoRepository;
            _fileUploader = fileUploader;
        }

        public OperationResult Create(CreateBasicInfo command)
        {
            var operation = new OperationResult();

            var persianResume = _fileUploader.Upload(command.PersianResume, "PersianResume");
            var englishResume = _fileUploader.Upload(command.EnglishResume, "EnglishResume");
            var recommendationLetter = _fileUploader.Upload(command.RecommendationLetters, "RecommendationLetters");

            var basicInfo = new BasicInformation(command.Name, command.Family, command.Age, command.Nationality, command.Job, command.Address, command.Email,
                command.Mobile, command.Instagram, command.Language, command.Experience, command.CompleteProject, command.HappyCustomers, command.Articles,
                persianResume, englishResume, recommendationLetter);

            _basicInfoRepository.Create(basicInfo);
            _basicInfoRepository.SaveChanges();

            return operation.Succedded();
        }

        public OperationResult Edit(EditBasicInfo command)
        {
            var operation = new OperationResult();
            var basicInfo = _basicInfoRepository.Get(command.Id);

            if (basicInfo == null)
            {
                return operation.Failed(ApplicationMessages.RecordNotFound);
            }

            var persianResume = _fileUploader.Upload(command.PersianResume, "PersianResume");
            var englishResume = _fileUploader.Upload(command.EnglishResume, "EnglishResume");
            var recommendationLetter = _fileUploader.Upload(command.RecommendationLetters, "RecommendationLetters");

            basicInfo.Edit(command.Name, command.Family, command.Age, command.Nationality, command.Job, command.Address, command.Email,
                command.Mobile, command.Instagram, command.Language, command.Experience, command.CompleteProject, command.HappyCustomers, command.Articles,
                persianResume, englishResume, recommendationLetter);

            _basicInfoRepository.SaveChanges();

            return operation.Succedded();
        }

        public EditBasicInfo GetDetails(long id)
        {
            return _basicInfoRepository.GetDetails(id);
        }

        public List<BasicInfoViewModel> GetList()
        {
            return _basicInfoRepository.GetList();
        }
    }
}
