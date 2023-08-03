﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrudAPI.Models
{
    public class BankTransaction : CommonEntity
    {
      
        [Required]
        public string TransactionType{ get; set; } //Credit or Debit
        [Required]
        public string Category { get; set; } //Opening Balance, Bank Interest, Bank Charges and Normal Transactions
        [Required]
        [RegularExpression(@"^\d+(\.\d{1,6})?$", ErrorMessage = "Amount should have up to 6 decimal places.")]
        public decimal Amount { get; set; }
        [Required]
        public DateTime TransactionDate { get; set; }
        [Required]
        public PaymentMethod PaymentMethod { get; set; }
        [Required]
        public int PaymentMethodId { get; set; }
        [Required]
        public int BankAccountId { get; set; }
        [Required]
        public BankAccount BankAccount { get; set; }
        

    }
}
