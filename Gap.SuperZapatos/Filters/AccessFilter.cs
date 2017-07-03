using System;
using System.Text;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Primitives;

namespace Gap.SuperZapatos.Filters
{
    public class AccessFilter : ActionFilterAttribute

    {
        public override void OnActionExecuting(ActionExecutingContext actionContext)
        {
            StringValues authorizationToken;
            var m = actionContext.HttpContext.Request.Headers.TryGetValue("Authorization", out authorizationToken);
            
            string decode = Encoding.UTF8.GetString(Convert.FromBase64String(authorizationToken));
            string[] split = decode.Split(':');
            var username = split[0];
            var password = split[1];
            
            if (username == "my_user" && password == "my_password")
                return;
            
            actionContext.Result = new Http403Result();
        }
    }
    
    internal class Http403Result : ActionResult
    {
        public override void ExecuteResult(ActionContext context)
        {
            context.HttpContext.Response.StatusCode = 403;
        }
    }
}