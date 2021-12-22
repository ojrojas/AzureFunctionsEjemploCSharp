using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure
{
    public class AzureFunctionsDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Activity> Activities { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;user=root;database=azuredb;port=30306;password=azurepassword;",
            x => x.ExecutionStrategy(c => new CustomExecutionStrategy(c)));
        }

        //  protected override void OnModelCreating(ModelBuilder builder)
        // {
        //     base.OnModelCreating(builder);
        //     builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        // }
    }
}
