using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrudAPI.Models
{
    public class Base_Account_Payment : CommonEntity
    {
       
        [Required]
        public string Name { get; set; }
    }
}
