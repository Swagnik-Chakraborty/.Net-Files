using Dependency.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Dependency.interfaces;
namespace Dependency.Controllers
{
  
public class HomeController : Controller
    {

        //Create a reference variable of IStudentRepository
        private readonly IStudentRepository _repository = null;


        //Initialize the variable through constructor
        public HomeController(IStudentRepository repository)
        {
            //the IoC container will automatically pass an instance of the TestStudentRepository to the constructor of HomeController. 
            _repository = repository;
        }
        public JsonResult Index()
        {

            //TestStudentRepository _repository = new TestStudentRepository();


            List<Student> allStudentDetails = _repository.GetAllStudent();
            return Json(allStudentDetails);
        }
        public JsonResult GetStudentDetails(int Id)
        {
            Student studentDetails = _repository.GetStudentById(Id);
            return Json(studentDetails);
        }

    }


}