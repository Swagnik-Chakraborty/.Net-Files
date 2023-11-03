using Authenticationdemo.filters;
using Authenticationdemo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Authenticationdemo.Controllers
{
    public class HomeController : Controller
    {

       
       
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ErrorMessage()
        {
            return View();
        }


    }
}