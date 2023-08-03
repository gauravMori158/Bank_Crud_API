using CrudAPI.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CrudAPI.DTOs
{
    public class BankAccountDTO : BankAccoutBaseDTO
    {
         
        public string AccountNumber { get; set; }
       
        public DateTime OpeningDate { get; set; }
               

    }
}
