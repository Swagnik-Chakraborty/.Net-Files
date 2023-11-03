using Microsoft.AspNetCore.Mvc;
using WebAppDemo.Models;
namespace WebAppDemo.Controllers
{
    public class EmployeeController1 : Controller
    {
        [Route("Employee/data")]
        public IActionResult Index()
        {

            List<Employee> emp = new List<Employee>()
            {
                new Employee{EmpId=1,EmpName="Swagnik Chakraborty",Designation="Software Developer"},
                 new Employee{EmpId=2,EmpName="Swastik Roy",Designation = "Tester"} 
                 

            };
            return View(emp);
        }
    }
}
