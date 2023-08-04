using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrudAPI.Models
{
    public class BankAccount : CommonEntity 
    {
        [ForeignKey("PersonId")]
        public Person Person { get; set; }


        [Required]
        [Range(10000000, 99999999, ErrorMessage = "Account Number must be an 8-digit number.")]
        public long AccountNumber { get; set; }
        [Required]
        public DateTime OpeningDate{ get; set; }

        public DateTime? ClosingDate{ get; set; }
         
        public decimal TotalBalance { get; set; }
        [Required]
        public int AccountTypeId { get; set; }
        public AccountType AccountType { get; set; }
        
        

    }
}
