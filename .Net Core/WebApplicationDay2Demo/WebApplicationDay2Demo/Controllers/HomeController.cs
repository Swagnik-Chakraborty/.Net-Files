using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplicationDay2Demo.Models;

namespace WebApplicationDay2Demo.Controllers
{
    public class HomeController : Controller
    {
       

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AboutUs()
        {
            return View();
        }
        public IActionResult ContactUs()
        {
            return View();
        }
       

    }
}