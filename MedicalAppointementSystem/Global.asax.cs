using MedicalAppointementBusinessLayer;
using MedicalAppointementSystem.App_Start;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
//using MedicalAppointementDataLayer;
using MedicalAppointementSystem.Controllers;
using MedicalAppointementBusinessLayer.Interfaces;

namespace MedicalAppointementSystem
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {

            var services = new ServiceCollection();

            // Register your services and repositories here
            services.AddScoped<IUserService,userService>();
            services.AddTransient<HomeController>();
            // register data acces repositories we can't access them from this refrence project
            DependencyConfig.RegisterDataLayerRepositories(services);

            var serviceProvider = services.BuildServiceProvider();
            // Set MVC DependencyResolver to use Microsoft DI

             DependencyResolver.SetResolver(new DefaultDependencyResolver(serviceProvider));


            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
