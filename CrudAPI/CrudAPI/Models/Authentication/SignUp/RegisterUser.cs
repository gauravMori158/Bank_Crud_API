using System.ComponentModel.DataAnnotations;

namespace CrudAPI.Models.Authentication.SignUp
{
    public class RegisterUser
    {
        [Required(ErrorMessage ="UserName is Require !")]
        public string UserName { get; set; }

        [EmailAddress]
        [Required(ErrorMessage ="Email is Require !")]
        public string EmailAddress { get; set; }
        [DataType(DataType.Password)]
        [Required(ErrorMessage ="Password is Require !")]
        public string Password { get; set; }
    }
}
