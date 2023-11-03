using Chacing.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System.Diagnostics;

namespace Chacing.Controllers
{
    public class HomeController : Controller
    {
        private IMemoryCache memoryCache;
        public HomeController(IMemoryCache memoryCache)
        {
            this.memoryCache = memoryCache;
        }



        public IActionResult Index()



        {
            DateTime currentTime;
            bool AlreadyExist = memoryCache.TryGetValue("CachedTime", out currentTime);
            if (!AlreadyExist)
            {
                currentTime = DateTime.Now;
                var cacheEntryOptions = new MemoryCacheEntryOptions().
                    SetAbsoluteExpiration(TimeSpan.FromSeconds(10));
                memoryCache.Set("CachedTime", currentTime, cacheEntryOptions);
                var cacheEntryOperations = new MemoryCacheEntryOptions()
                {
                    AbsoluteExpiration = DateTime.Now.AddMinutes(5),
                    Priority = CacheItemPriority.High,
                    SlidingExpiration = TimeSpan.FromMinutes(5)
                };
            }
            return View(currentTime);
        }

       

        
    }
}