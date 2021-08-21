using _01_Query.Contract.BasicInfo;
using _01_Query.Contract.EducationExperience;
using _01_Query.Contract.JobExperience;
using _01_Query.Contract.Skills;
using _01_Query.Query;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PersonalInfo.Domain.BasicInformation;
using PersonalInfo.Domain.EducationExperience;
using PersonalInfo.Domain.JobExperience;
using PersonalInfo.Domain.Skills;
using PersonalInfoManagement.Application;
using PersonalInfoManagement.Application.Contract.BasicInfo;
using PersonalInfoManagement.Application.Contract.EducationExperience;
using PersonalInfoManagement.Application.Contract.JobExperience;
using PersonalInfoManagement.Application.Contract.Skill;
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

            services.AddTransient<IJobExperienceApplication, JobExperienceApplication>();
            services.AddTransient<IJobExperienceRepository, JobExperienceRepository>();

            services.AddTransient<IEducationExperienceApplication, EducationExperienceApplication>();
            services.AddTransient<IEducationExperienceRepository, EducationExperienceRepository>();

            services.AddTransient<ISkillApplication, SkillApplication>();
            services.AddTransient<ISkillRepository, SkillRepository>();









            services.AddTransient<ISkillQuery, SkillQuery>();
            services.AddTransient<IBasicInfoQuery, BasicInfoQuery>();
            services.AddTransient<IJobExperienceQuery, JobExperienceQuery>();
            services.AddTransient<IEducationExperienceQuery, EducationExperienceQuery>();





            services.AddDbContext<PersonalInfoContext>(x => x.UseSqlServer(connectionString));
        }
    }
}
