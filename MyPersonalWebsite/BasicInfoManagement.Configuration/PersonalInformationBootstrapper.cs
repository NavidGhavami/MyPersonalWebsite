using _01_Query.Contract;
using _01_Query.Query;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PersonalInfo.Domain.BasicInformation;
using PersonalInfoManagement.Application;
using PersonalInfoManagement.Application.Contract.BasicInfo;
using PersonalInfoManagement.Infrastructure.EFCore;
using PersonalInfoManagement.Infrastructure.EFCore.Repository;

namespace PersonalInfoManagement.Configuration
{
    public class PersonalInformationBootstrapper
    {
        public static void Configure(IServiceCollection services, string connectionString)
        {
            services.AddTransient<IBasicInfoApplication, BasicInfoApplication>();
            services.AddTransient<IBasicInfoRepository, BasicInfoRepository>();















            services.AddTransient<IBasicInfoQuery, BasicInfoQuery>();
















            services.AddDbContext<PersonalInfoContext>(x => x.UseSqlServer(connectionString));
        }
    }
}
