using Microsoft.EntityFrameworkCore;
using ServiceManagement.Domain.ClientsOpinion;
using ServiceManagement.Domain.ContactMe;
using ServiceManagement.Domain.Customers;
using ServiceManagement.Domain.Plans;
using ServiceManagement.Domain.Services;
using ServiceManagements.Infrastructure.EFCore.Mapping;

namespace ServiceManagements.Infrastructure.EFCore
{
    public class ServiceContext : DbContext
    {
        public DbSet<Services> Services { get; set; }
        public DbSet<Plans> Plans { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<ClientsOpinion> ClientsOpinions { get; set; }
        public DbSet<ContactMe> ContactMe { get; set; }


        public ServiceContext(DbContextOptions<ServiceContext> options) : base(options)
        {

        }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var assembly = typeof(ServiceMapping).Assembly;
            modelBuilder.ApplyConfigurationsFromAssembly(assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
