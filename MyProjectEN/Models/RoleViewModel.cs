using System.ComponentModel.DataAnnotations;

namespace MyProjectEN.Models
{
    public class RoleViewModel
    {
        [Required(ErrorMessage = "please enter role name")]
        public string name { get; set; }
    }
}
