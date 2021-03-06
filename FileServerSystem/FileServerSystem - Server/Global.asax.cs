﻿using FileServerSystemServer.Common;
using FileServerSystemServer.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace FileServerSystemServer
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        private IBootStrapper _bootstrapper;

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);

            _bootstrapper = new BootStrapper();

            _bootstrapper.InitializeApplication();
        }
    }
}