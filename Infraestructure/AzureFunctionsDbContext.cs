using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure
{
    public class AzureFunctionsDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}
