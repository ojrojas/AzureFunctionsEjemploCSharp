using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Infraestructure
{
    public class AzureFunctionsDbContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public AzureFunctionsDbContext() {}

        public DbSet<User> Users { get; set; }
        public DbSet<Activity> Activities { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data source=azuredb.db");
        }
    }
}
