using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrudAPI.Models
{
    public class AccountType : CommonProp
    {

       
        [Required]
        public string Name { get; set; }

        public ICollection<BankAccount>  BankAccount { get; set; }

    }
}
