using CrudAPI.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CrudAPI.DTOs.BankTransaction
{
    public class BankTransactionDTO
    {
        public PersonDTO Person { get; set; }

        public TransactionType TransactionType { get; set; } //Credit or Debit

        public Category Category { get; set; } //Opening Balance, Bank Interest, Bank Charges and Normal Transactions

        public decimal Amount { get; set; }

        public DateTime TransactionDate { get; set; }

        public long AccountNumber { get; set; }
        public int PaymentMethodId { get; set; }



    }
}
