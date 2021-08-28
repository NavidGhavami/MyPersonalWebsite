using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ServiceManagement.Application.Contract.Services;
using ServiceManagement.Domain.Services;
using ServiceManagements.Infrastructure.EFCore;
using ServiceManagements.Infrastructure.EFCore.Repository;

namespace ServiceManagement.Configuration
{
    public class ServicesBootstrapper
    {
        public void Configure(IServiceCollection services, string connectionString)
        {


            services.AddTransient<IServicesApplication, ServiceApplication>();
            services.AddTransient<IServicesRepository, ServicesRepository>();






















            services.AddDbContext<ServiceContext>(x => x.UseSqlServer(connectionString));

        }
    }
}
