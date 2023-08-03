using System.ComponentModel.DataAnnotations;

namespace CrudAPI.DTOs
{
    public class BankAccountUpdateDTO 
    {
        public PersonDTO Person { get; set; }

        public int AccountTypeId { get; set; }
        DateTime? ClosingDate { get; set; }
     
    }
}
