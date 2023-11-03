using System.ComponentModel.DataAnnotations;

namespace filtersDemo.Models
{
    public class Employee
    {
        [Required(ErrorMessage = "Id Required")]
        public int EmpId { set; get; }



        [Required(ErrorMessage = "Name is Required")]
        public string EmpName { set; get; }
    }
}
