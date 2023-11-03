using Microsoft.AspNetCore.Mvc;

namespace CustomMiddleWareDemo.Controllers
{
    //[Route("login")]
    public class LoginController : Controller
    {
        //[Route("")]
        //[Route("index")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        //[Route("process")]
        public IActionResult Process(string username, string password)
        {
            if (username != null && password != null && username.Equals("admin") && password.Equals("123"))
            {
                HttpContext.Session.SetString("username", username);
                return View("Welcome");
            }
            else
            {
                ViewBag.error = "Invalid Credentials";
                return View("Index");
            }
        }

    }
}
