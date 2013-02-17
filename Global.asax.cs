using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Text.RegularExpressions;

namespace MvcCms
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }

        

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "PostIndex",
                "blog",
                new { controller = "Post", action = "Index"}
             );

            routes.MapRoute(
                "Message",
                "message",
                new { controller = "Message", action = "Index" }
             );

            routes.MapRoute(
                "MessageSuccess",
                "message/confirmation/{id}",
                new { controller = "Message", action = "Success" }
             );

            routes.MapRoute(
                "Logon",
                "logon",
                new { controller = "Account", action = "LogOn" }
             );

   
            routes.MapRoute(
                "Page",
                "pages/{id}/{title}",
                new { controller = "Page", action = "Details", id = UrlParameter.Optional }
             );

            routes.MapRoute(
                "Post",
                "blog/{id}/{title}",
                new { controller = "Post", action = "Details", id = UrlParameter.Optional }
             );

            routes.MapRoute(
                "PostArchive",
                "blog/archives/{year}/{month}",
                new { controller = "Post", action = "GetArchives"}
             );


            routes.MapRoute(
               "Tag",
               "blog/tag/{tag}/{title}",
               new { controller = "Post", action = "Navigation", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                "Default", // Route name
                "{controller}/{action}/{id}", // URL with parameters
                new { controller = "Home", action = "Index", id = UrlParameter.Optional } // Parameter defaults
            );

       

        }

        protected void Application_Start()
        {
            System.Data.Entity.Database.SetInitializer(new MvcCms.Models.SampleData());
            AreaRegistration.RegisterAllAreas();

            // Use LocalDB for Entity Framework by default
            Database.DefaultConnectionFactory = new SqlConnectionFactory(@"Data Source=(localdb)\v11.0; Integrated Security=True; MultipleActiveResultSets=True");

            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);
        }
    }
}