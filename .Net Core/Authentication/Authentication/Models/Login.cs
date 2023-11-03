using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Authentication.Models
{
    public class Login
    {
        [Required(ErrorMessage = "Please Enter User Name")]
        [Display(Name = "User Name")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Please Enter Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
