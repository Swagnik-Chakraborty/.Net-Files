using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplicationDay2FormValidation.Models;

namespace WebApplicationDay2FormValidation.Controllers
{
    public class HomeController : Controller
    {
        

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Employee emp)
        {
           if (ModelState.IsValid)
            {
                return RedirectToAction("Message");
            }



            return View();
        }

        public ActionResult Message()
        {
            return View();
        }
    }
}