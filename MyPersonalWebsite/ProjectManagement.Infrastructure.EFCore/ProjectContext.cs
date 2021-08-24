using Microsoft.EntityFrameworkCore;
using ProjectManagement.Domain.Project;
using ProjectManagement.Domain.ProjectCategory;
using ProjectManagement.Infrastructure.EFCore.Mapping;

namespace ProjectManagement.Infrastructure.EFCore
{
    public class ProjectContext : DbContext
    {

        public DbSet<ProjectCategory> ProjectCategories { get; set; }
        public DbSet<Project> Projects { get; set; }






        public ProjectContext(DbContextOptions<ProjectContext> options) : base(options)
        {

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var assembly = typeof(ProjectCategoryMapping).Assembly;
            modelBuilder.ApplyConfigurationsFromAssembly(assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
