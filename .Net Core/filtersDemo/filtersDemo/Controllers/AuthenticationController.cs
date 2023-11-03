using filtersDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace filtersDemo.Controllers
{
    public class AuthenticationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult Index(Employee emp)
        {
            if (ModelState.IsValid)
            {
                if (model.EmpId.ToLower() == "admin" && model.Password == "admin")
                {
                    //Store the Username in session
                    Session["UserName"] = model.UserName;
                    //Then redirect to the Index Action method of Home Controller
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Invalid User Name or Password");
                    return View(model);
                }
            }



            return View();
        }
    }
}
