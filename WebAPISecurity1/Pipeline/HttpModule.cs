using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPISecurity1
{
    public class HttpModule : IHttpModule
    {
        public void Dispose()
        {
            
        }

        public void Init(HttpApplication context)
        {
            context.BeginRequest += context_BeginRequest;
        }
               

        private void context_BeginRequest(object sender, EventArgs eventArgs)
        {
            Helper.Write("HttpModule", HttpContext.Current.User);

        }
    }
}