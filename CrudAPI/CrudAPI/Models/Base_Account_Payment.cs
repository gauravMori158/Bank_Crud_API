using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrudAPI.Models
{
    public class Base_Account_Payment : CommonProp
    {
       
        [Required]
        public string Name { get; set; }
    }
}
