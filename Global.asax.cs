﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace WebApplication1
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

        }
    }
    public static void RegisterRoutes(RouteCollection  Routes)
    {
        routes.IgnoreRoute("{resouce}.axd/{* pathInfo}");
routes.MapRoute(
    name:"Default",
    url: "{contorller}/{action}/{id}",
    defaults: new{controller="Home",action="index", id = UrlParameter}
    );

    
}
