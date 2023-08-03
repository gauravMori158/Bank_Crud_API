using CrudAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CrudAPI.Configuration
{
    public class AccountTypeConfiguration : IEntityTypeConfiguration<AccountType>
    {
        public void Configure(EntityTypeBuilder<AccountType> builder)
        {
            builder.HasData(
                new AccountType()
                {
                    Id = 1,
                    Name = "Liability"
                },
               new AccountType()
               {
                   Id = 2,
                   Name = "Asset"
               });
        }
    }
}
