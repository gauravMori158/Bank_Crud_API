using CrudAPI.Configuration;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Drawing;
using System.Reflection.Emit;

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

            builder.ApplyConfiguration(new AccountTypeConfiguration());
            builder.ApplyConfiguration(new PaymentConfiguration());
            
        }
        public DbSet<AccountType> AccountTypes { get; set; }
        public DbSet<BankAccount> BankAccounts { get; set; }
        public DbSet<Person>Persons { get; set; }
        public DbSet<BankTransaction> BankTransactions { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; } 
    }
}
