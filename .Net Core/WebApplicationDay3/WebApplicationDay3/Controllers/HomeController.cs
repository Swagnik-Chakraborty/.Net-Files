using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplicationDay3.Models;

namespace WebApplicationDay3.Controllers
{
    public class HomeController : Controller
    {
       

        public IActionResult Index()
        {
            return View();
        }

       
    }
}