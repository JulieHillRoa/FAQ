using FAQ.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace FAQ
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);

            Database.SetInitializer<FAQDB>(new DbInitializer());

            using (var db = new FAQDB())
            {
                {
                    db.Database.Initialize(true);
                }
            }
        }
    }
}
