using System.ComponentModel.DataAnnotations;

namespace WebApplicationDay2FormValidation.Models
{
    public class Employee
    {
        [Required(ErrorMessage = "Id Required")]
        public int EmpId { set; get; }



        [Required(ErrorMessage = "Name is Required")]
        public string EmpName { set; get; }



        [Range(1000, int.MaxValue)]
        public int Salary { set; get; }




        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid Email Address.")]
        public string Email { get; set; }




        [DataType(DataType.Date)]
        public DateTime Birthdate { get; set; }




        [DataType(DataType.Password)]
        [StringLength(255, MinimumLength = 8)]
        [Required()]
        public string Password { get; set; }




        [Compare("Password")]
        [DataType(DataType.Password)]
        [StringLength(255, MinimumLength = 8)]
        [Required()]
        public string ConfirmPassword { get; set; }



    }
}
