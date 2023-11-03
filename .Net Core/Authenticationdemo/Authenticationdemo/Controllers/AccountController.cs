using Microsoft.AspNetCore.Mvc;
using Authenticationdemo.Models;
namespace Authenticationdemo.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(User model)
        {
               if (model.UserName == "admin" && model.Password == "admin")
                {
                   
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    return RedirectToAction("ErrorMessage","Home");
                }
            
         }

        
    }
}
