using Microsoft.AspNetCore.Mvc;

namespace WebAppDemo.Controllers
{
    public class SampleController1 : Controller
    {
        //public ContentResult Index()
        //{
        //    string s = "Swagnik Chakraborty";
        //    return Content(s);
        //}
        public JsonResult Index()
        {
            return Json(new[] { "Swagnik", "swastik" });
        }
    }
}
