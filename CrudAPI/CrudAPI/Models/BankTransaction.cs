using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrudAPI.Models
{
    public class BankTransaction : CommonEntity
    {
        
        [Required]
        public TransactionType TransactionType{ get; set; } //Credit or Debit
        [Required]
        public Category Category { get; set; } //Opening Balance, Bank Interest, Bank Charges and Normal Transactions
        [Required]
        [RegularExpression(@"^\d+(\.\d{1,6})?$", ErrorMessage = "Amount should have up to 6 decimal places.")]
        public decimal Amount { get; set; }
        [Required]
        public DateTime TransactionDate { get; set; }

        [ForeignKey("PersonId")]
        public virtual Person Person { get; set; }

        public virtual AccountType AccountType { get; set; }

        public virtual PaymentMethod PaymentMethod { get; set; }

    }
}
