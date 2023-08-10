using CrudAPI.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CrudAPI.DTOs.BankAccount
{
    public class BankAccountDTO
    {
        public PersonDTO Person { get; set; }

        public int AccountTypeId { get; set; }


        public long AccountNumber { get; set; }

        public DateTime OpeningDate { get; set; }


    }
}
