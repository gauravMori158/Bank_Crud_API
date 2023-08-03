using System.ComponentModel.DataAnnotations;

namespace CrudAPI.Models
{
    public class PaymentMethod : CommonProp
    {
      
        [Required]
        public string Name { get; set; }
    }
}
