using System.ComponentModel.DataAnnotations;

namespace CrudAPI.Models.Authentication
{
    public class LoginModel
    {
        [Required(ErrorMessage = "User Name is Required !")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is Required !")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
