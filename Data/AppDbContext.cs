using Microsoft.EntityFrameworkCore;
using WebAPI.Data.Entities;
namespace WebAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Cliente> Cliente { get; set; }

        public DbSet<Customer> Customer { get; set; }
    }
}