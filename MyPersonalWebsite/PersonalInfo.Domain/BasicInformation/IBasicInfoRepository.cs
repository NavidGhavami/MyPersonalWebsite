using System.Collections.Generic;
using _0_Framework.Domain;
using PersonalInfoManagement.Application.Contract.BasicInfo;

namespace PersonalInfo.Domain.BasicInformation
{
    public interface IBasicInfoRepository : IRepository<long, BasicInformation>
    {
        EditBasicInfo GetDetails(long id);
        List<BasicInfoViewModel> GetList();
    }
}
