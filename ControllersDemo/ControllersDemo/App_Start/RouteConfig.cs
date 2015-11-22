using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ControllersDemo
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            //www.facebook.com
            //home/index/1
            //products-cpu/pid
            //products
            //products/cpu
            //products/headphones/id
            routes.MapRoute(
                name: "Default1",
                url: "{controller}/{action}/{id}",
                defaults: new {
                    controller = "Products",
                    action = "Index",
                    id = UrlParameter.Optional
                },
                constraints:new { id = @"\d+"}
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
