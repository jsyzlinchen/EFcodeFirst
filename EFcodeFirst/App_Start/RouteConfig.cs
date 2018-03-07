using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace EFcodeFirst
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            var spaces = new string[] { "EFcodeFirst.Controllers" };// 这个就是添加了外面控制器
            routes.MapRoute(
                namespaces: spaces,// 这个就是添加了外面控制器
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
                //defaults: new { controller = "Account", action = "Login", id = UrlParameter.Optional }
            );
        }
    }
}
