using Microsoft.AspNetCore.Mvc;

namespace Logging.Controllers
{
    public class LogDemoController : Controller
    {
        private readonly ILogger<LogDemoController> _logger;








        public LogDemoController(ILogger<LogDemoController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {



            _logger.LogInformation("Page Visited @ " + DateTime.Now.ToLongTimeString());



            _logger.LogWarning("Logging Warning Message");
            _logger.LogError("Logging Error Message");
            _logger.LogCritical("Logging Critical Message");
            return View();
        }









    }
}
