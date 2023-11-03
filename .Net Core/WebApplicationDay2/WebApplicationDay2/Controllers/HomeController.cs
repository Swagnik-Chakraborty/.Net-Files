using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplicationDay2.Models;

namespace WebApplicationDay2.Controllers
{
    public class HomeController : Controller
    {
        

       
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }



        [HttpPost]
        //Model Binding
        public string Index(Employee e)
        {
            return " Employee Name is " + e.Name + "\n Gender is " + e.Gender + "\n Age is " + e.Age + "\n Employee is having a salary of Rs " + e.Salary + "\n Designation is " + e.Designation + "\n Experience is of " + e.Experience +" years" +"\n Married " + e.Married+ "\n JobOpportunities " + e.JobOpportunities;
        }


    }
}