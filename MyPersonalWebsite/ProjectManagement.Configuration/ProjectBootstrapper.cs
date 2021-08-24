using _01_Query.Contract.Project;
using _01_Query.Contract.ProjectCategory;
using _01_Query.Query;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ProjectManagement.Application;
using ProjectManagement.Application.Contract.Project;
using ProjectManagement.Application.Contract.ProjectCategory;
using ProjectManagement.Domain.Project;
using ProjectManagement.Domain.ProjectCategory;
using ProjectManagement.Infrastructure.EFCore;
using ProjectManagement.Infrastructure.EFCore.Repository;

namespace ProjectManagement.Configuration
{
    public class ProjectBootstrapper
    {
        public static void Configure(IServiceCollection services, string connectionString)
        {

            services.AddTransient<IProjectCategoryApplication, ProjectCategoryApplication>();
            services.AddTransient<IProjectCategoryRepository, ProjectCategoryRepository>();

            services.AddTransient<IProjectApplication, ProjectApplication>();
            services.AddTransient<IProjectRepository, ProjectRepository>();




            services.AddTransient<IProjectCategoryQuery, ProjectCategoryQuery>();
            services.AddTransient<IProjectQuery, ProjectQuery>();






            services.AddDbContext<ProjectContext>(x => x.UseSqlServer(connectionString));

        }
    }
}
