using System.ComponentModel.DataAnnotations;

namespace MyProjectEN.Models
{
    public class UserSignUpViewModel
    {
        [Display(Name = "Name Surname")]
        [Required(ErrorMessage = "Please enter name and surname!")]
        public string NameSurname { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "Please enter password")]
        public string Password { get; set; }

        [Display(Name = "Password again")]
        [Compare("Password", ErrorMessage = "Passwords do not match!")]
        public string ConfirmPassword { get; set; }


        [Display(Name = "E-Mail Address")]
        [Required(ErrorMessage = "Please enter your mail!")]
        public string Mail { get; set; }

        [Display(Name = "UserName")]
        [Required(ErrorMessage = "Please enter your username")]
        public string UserName { get; set; }

    }
}
