using _01_Query.Contract.Plans;
using _01_Query.Contract.Services;
using _01_Query.Query;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ServiceManagement.Application;
using ServiceManagement.Application.Contract.Plans;
using ServiceManagement.Application.Contract.Services;
using ServiceManagement.Domain.Plans;
using ServiceManagement.Domain.Services;
using ServiceManagements.Infrastructure.EFCore;
using ServiceManagements.Infrastructure.EFCore.Repository;

namespace ServiceManagement.Configuration
{
    public class ServiceBootstrapper
    {
        public static void Configure(IServiceCollection services, string connectionString)
        {

            services.AddTransient<IServicesApplication, ServicesApplication>();
            services.AddTransient<IServicesRepository, ServicesRepository>();

            services.AddTransient<IPlansApplication, PlansApplication>();
            services.AddTransient<IPlansRepository, PlansRepository>();




            services.AddTransient<IServiceQuery, ServicesQuery>();
            services.AddTransient<IPlansQuery, PlansQuery>();









            services.AddDbContext<ServiceContext>(x => x.UseSqlServer(connectionString));

        }
    }
}
