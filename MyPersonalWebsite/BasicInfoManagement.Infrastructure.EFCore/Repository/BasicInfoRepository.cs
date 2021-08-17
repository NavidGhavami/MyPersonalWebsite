using System.Collections.Generic;
using System.Linq;
using _0_Framework.Application;
using _0_Framework.Infrastructure;
using PersonalInfo.Domain.BasicInformation;
using PersonalInfoManagement.Application.Contract.BasicInfo;

namespace PersonalInfoManagement.Infrastructure.EFCore.Repository
{
    public class BasicInfoRepository : RepositoryBase<long, BasicInformation>, IBasicInfoRepository
    {

        private readonly PersonalInfoContext _personalInfoContext;
        public BasicInfoRepository(PersonalInfoContext personalInfoContext) : base(personalInfoContext)
        {
            _personalInfoContext = personalInfoContext;
        }

        public EditBasicInfo GetDetails(long id)
        {
            return _personalInfoContext.BasicInformations.Select(x => new EditBasicInfo
            {
                Id = x.Id,
                Name = x.Name,
                Family = x.Family,
                Age = x.Age,
                Nationality = x.Nationality,
                Job = x.Job,
                Address = x.Address,
                Email = x.Email,
                Mobile = x.Mobile,
                Instagram = x.Instagram,
                Language = x.Language,
                Experience = x.Experience,
                HappyCustomers = x.HappyCustomers,
                CompleteProject = x.CompleteProject,
                Articles = x.Articles,



            }).FirstOrDefault(x => x.Id == id);
        }

        public List<BasicInfoViewModel> GetList()
        {
            return _personalInfoContext.BasicInformations.Select(x => new BasicInfoViewModel
            {
                Id = x.Id,
                Name = x.Name,
                Family = x.Family,
                Age = x.Age,
                Job = x.Job,
                Mobile = x.Mobile,
                CreationDate = x.CreationDate.ToFarsi()
            }).ToList();
        }
    }
}
