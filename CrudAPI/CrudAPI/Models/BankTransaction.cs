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

        [Required]
        [Range(10000000, 99999999, ErrorMessage = "Account Number must be an 8-digit number.")]
        public long AccountNumber { get; set; }

        [ForeignKey("PersonId")]
        public  Person Person { get; set; }

        public int PaymentMethodId { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        
        

    }
}
