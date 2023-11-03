using filtersDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using filtersDemo.Controllers;
namespace filtersDemo.Controllers
{
    public class HomeController : Controller
    {
        [TimeController]
        public String Index()
        {
            return "This is the index of home controller";
        }

        [ChangeView]
        public ActionResult Message()
        {
            return View();
        }
    }
}