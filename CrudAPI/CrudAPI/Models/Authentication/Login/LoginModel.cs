using System.ComponentModel.DataAnnotations;

namespace CrudAPI.Models.Authentication.Login
{
    public class LoginModel
    {
        [Required(ErrorMessage = "UserName is Require !")]
        public string UserName { get; set; }

       
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Password is Require !")]
        public string Password { get; set; }
    }
}
