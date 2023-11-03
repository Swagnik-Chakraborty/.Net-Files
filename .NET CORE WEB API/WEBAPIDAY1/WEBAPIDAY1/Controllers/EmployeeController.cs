using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WEBAPIDAY1.Model;

namespace WEBAPIDAY1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private List<Employee> _employee = new List<Employee>
    {
        new Employee { Id = 1, Name = "Swagnik" },
        new Employee { Id = 2, Name = "Swastik" }
    };

        [HttpGet]

        //http://localhost:5080/api/Employee
        public IActionResult GetAll()
        {
            return Ok(_employee);
        }


        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var employee = _employee.Find(x => x.Id == id);
            if (employee == null)
                return NotFound();

            return Ok(employee);
        }



    }
}
