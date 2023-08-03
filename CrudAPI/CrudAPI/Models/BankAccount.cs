using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrudAPI.Models
{
    public class BankAccount : CommonEntity 
    {
        [ForeignKey("PersonId")]
        public virtual Person Person { get; set; }

        [Required]
        [StringLength(8,MinimumLength =8,ErrorMessage ="Account Number Must Have 8 Digits")]
         
        public string AccountNumber { get; set; }
        [Required]
        public DateTime OpeningDate{ get; set; }

        public DateTime? ClosingDate{ get; set; }
         
        public decimal? TotalBalance { get; set; }
        [Required]
        public int AccountTypeId { get; set; }
        

    }
}
