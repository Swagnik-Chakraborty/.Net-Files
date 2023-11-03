using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebAppDemo.Models;

namespace WebAppDemo.Controllers
{
    public class HomeController : Controller
    {
       

        public IActionResult Index()
        {
            return View();
        }


        public string Greet()
        {
            return "Hello Swagnik";
        }
        public string Greet1(string name)
        {
            return "Hello Swagnik"+ name;
        }
        public IActionResult MyIndex()
        {


            ViewBag.State = "West Bengal";
            ViewData["Age"] = "23";
            TempData["Designation"] = "Software Engineer";



            string[] places = { "Pune", "Kolkata", "delhi" };
            ViewBag.Place = places;


            ViewBag.Places1 = new List<string>()
            {
                "Chennai","Vizag","Pune"
            };


            ViewData["NewPlace"]= places;


            ViewData["NewPlace1"] = new List<string>()
            {
                "Chennai","Vizag","Pune"
            };


            TempData["NewLocation"] = places;

            TempData["NewLocation1"] = new List<string>()
            {
                "Chennai","Vizag","Pune"
            };


            //  return RedirectToAction("Index","EmployeeController1");
            return View();
        }
        public IActionResult MyIndex3()
        {
            return View();
        }

    }
}