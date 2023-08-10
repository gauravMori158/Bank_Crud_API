using CrudAPI.Configuration;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
 

namespace CrudAPI.Models.Database
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option):base(option)
        {
                
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            SeedRoles(builder);

            builder.ApplyConfiguration(new AccountTypeConfiguration());
            builder.ApplyConfiguration(new PaymentConfiguration());
            
        }

        private static void SeedRoles(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole() { ConcurrencyStamp = "1", Name = "Admin", NormalizedName = "Admin" },
                new IdentityRole() { ConcurrencyStamp = "2", Name = "User", NormalizedName = "User" },
                new IdentityRole() { ConcurrencyStamp = "3", Name = "HR", NormalizedName = "HR" }
                );
        }

        public DbSet<AccountType> AccountTypes { get; set; }
        public DbSet<BankAccount> BankAccounts { get; set; }
        
        public DbSet<BankTransaction> BankTransactions { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; } 
    }
}
