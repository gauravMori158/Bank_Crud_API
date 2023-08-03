using System.ComponentModel.DataAnnotations;

namespace CrudAPI.DTOs
{
    public class BankAccountUpdateDTO : BankAccoutBaseDTO
    {
        DateTime? ClosingDate { get; set; }
     
    }
}
