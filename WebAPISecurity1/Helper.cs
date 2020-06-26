using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Principal;
using System.Web;

namespace WebAPISecurity1
{
    public static class Helper
    {
        public static void Write(string Stage, IPrincipal principal)
        {
            Debug.WriteLine("......" + Stage + ".......");
            if (principal == null ||
                    principal.Identity == null ||
                    !principal.Identity.IsAuthenticated)
                    {
                        Debug.WriteLine("Anonymous User"); 
                    }
            else
            {
                Debug.WriteLine("User:" + principal.Identity.Name);
            }
            Debug.WriteLine("\n");
        }
    }
}