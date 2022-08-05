using System.ComponentModel.DataAnnotations;

namespace MyProjectEN.Models
{
    public class UserSignInViewModel
    {
        [Required(ErrorMessage = "Please enter your usaername")]
        public string username { get; set; }

        [Required(ErrorMessage = "Please enter your password")]
        public string password { get; set; }
    }
}
