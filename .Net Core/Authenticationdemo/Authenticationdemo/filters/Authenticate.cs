using Microsoft.AspNetCore.Mvc.Filters;
using System;
namespace Authenticationdemo.filters
{
    public interface IAuthenticationfilter
    {

        void OnAuthentication(AuthenticationContent filtercontent);
        void OnAuthenticationChallenge(AuthenticationChallengeContent filtercontent);
    }
    public class Authenticate : ActionFilterAttribute, IAuthenticationfilter
    {
        public void OnAuthentication(AuthenticationContent filterContext)
        {
            //if (string.IsNullOrEmpty(Convert.ToString(filterContext.HttpContext.Session["UserName"])))
            //{
            //    filterContext.Result = new HttpUnauthorizedResult();
            //}
        }


        //public void OnAuthentication(AuthenticationContent filtercontent)
        //{
        //    throw new NotImplementedException();
        //}

        public void OnAuthenticationChallenge(AuthenticationChallengeContent filtercontent)
        {
            throw new NotImplementedException();
        }
    }
}
