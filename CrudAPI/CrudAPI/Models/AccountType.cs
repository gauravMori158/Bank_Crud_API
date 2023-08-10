using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrudAPI.Models
{
    public class AccountType : Base_Account_Payment
    {
        public ICollection<BankAccount> BankAccounts { get; set; }

    }
}
