using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Controllers;

namespace WebAPISecurity1.Pipeline
{
    public class TestAuthorizationFilterAttribute: AuthorizeAttribute
    {
        protected override bool IsAuthorized(HttpActionContext actionContext)
        {
            Helper.Write("AutorizationFilter", actionContext.RequestContext.Principal);
            return true;
            //return base.IsAuthorized(actionContext);
        }
    }
}