using Microsoft.EntityFrameworkCore;
using ServiceManagement.Domain.Services;

namespace ServiceManagements.Infrastructure.EFCore
{
    public class ServiceContext : DbContext
    {
        public DbSet<Services> Services { get; set; }







        public ServiceContext(DbContextOptions<ServiceContext> options) : base(options)
        {

        }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var assembly = typeof(Services).Assembly;
            modelBuilder.ApplyConfigurationsFromAssembly(assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
