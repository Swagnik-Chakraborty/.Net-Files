using Dependency.interfaces;
using Dependency.Models;
using Microsoft.AspNetCore.Mvc;

namespace Dependency.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeRepository _repository = null;


        //Initialize the variable through constructor
        public EmployeeController(IEmployeeRepository repository)
        {
            //the IoC container will automatically pass an instance of the TestStudentRepository to the constructor of HomeController. 
            _repository = repository;
        }
        public JsonResult GetAllEmployeeDetails()
        {

            //TestStudentRepository _repository = new TestStudentRepository();


            List<Employee> allEmployeeDetails = _repository.GetAllEmployee();
            return Json(allEmployeeDetails);
        }
        public JsonResult GetEmpDetails(int Id)
        {
            Employee empDetails = _repository.GetEmpById(Id);
            return Json(empDetails);
        }

    }
}

