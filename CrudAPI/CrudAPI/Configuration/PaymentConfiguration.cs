using CrudAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CrudAPI.Configuration
{
    public class PaymentConfiguration : IEntityTypeConfiguration<PaymentMethod>
    {
        public void Configure(EntityTypeBuilder<PaymentMethod> builder)
        {
            builder.HasData(
                new PaymentMethod()
                {
                    Id = 1,
                    Name = "Cash"
                },
                new PaymentMethod()
                {
                    Id = 2,
                    Name = "Cheque"
                },
                new PaymentMethod()
                {
                    Id = 3,
                    Name = "NEFT"
                },
                new PaymentMethod()
                {
                    Id = 4,
                    Name = "RTGS"
                },
                new PaymentMethod()
                {
                    Id = 5,
                    Name = "Other"
                }
                );
        }
    }
}
