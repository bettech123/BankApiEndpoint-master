
using Microsoft.EntityFrameworkCore;
using BankApiEndpoint.Models;

namespace BankApiEndpoint.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :
            base(options)
        {
            Database.SetCommandTimeout(150000);
        }

        public ApplicationDbContext()
        {
        }
        public DbSet<NIPFundTransfer> NIPFundTransfer { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.EnableSensitiveDataLogging();
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(Local);Database=EgoleBankAPI;Integrated Security=true;",
                    builder => builder.EnableRetryOnFailure());
            }
        }

        
    }
}
