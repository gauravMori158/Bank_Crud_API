using System.ComponentModel.DataAnnotations;

namespace CrudAPI.Models
{
    public class Base_BankAccount_Transaction : CommonProp
    {
        [Required]
        public string FirstName { get; set; }
        public string? MiddleName { get; set; }
        [Required]
        public string LastName { get; set; }
    }
}
