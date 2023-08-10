using System.ComponentModel.DataAnnotations;

namespace CrudAPI.Models
{
    public class PaymentMethod : Base_Account_Payment
    {
       public ICollection<BankTransaction> BankTransactions { get; set; }   
    }
}
 