using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Dependencies;

namespace MedicalAppointementSystem.App_Start
{

    using System;
    using System.Collections.Generic;
    using System.Web.Mvc;
    using Microsoft.Extensions.DependencyInjection;

    public class DefaultDependencyResolver : IDependencyResolver
    {
        private readonly ServiceProvider _serviceProvider;

        public DefaultDependencyResolver(ServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public object GetService(Type serviceType)
        {
            var test = _serviceProvider.GetService(serviceType);
            return test;
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return _serviceProvider.GetServices(serviceType);
        }
    }



}
