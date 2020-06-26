using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Net.Http;

namespace WebAPISecurity1.Pipeline
{
    public class TestController : ApiController
    {
        [TestAuthenticationFilter]
        [TestAuthorizationFilter]
        public IHttpActionResult Get()
        {
            Helper.Write("Controller", User);
            

            return Ok();
        }
    }
}