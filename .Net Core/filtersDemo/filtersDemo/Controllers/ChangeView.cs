using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace filtersDemo.Controllers
{
    public class ChangeView : Attribute, IResultFilter
    {
        public void OnResultExecuting(ResultExecutingContext context)
        {
            context.Result = new ViewResult
            {
                ViewName = "List"
            };
        }



        public void OnResultExecuted(ResultExecutedContext context)
        {
        }
    }
}
