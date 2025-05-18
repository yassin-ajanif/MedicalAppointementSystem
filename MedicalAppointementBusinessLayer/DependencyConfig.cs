using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using MedicalAppointementDataLayer;
using MedicalAppointementDataLayer.Interfaces;

namespace MedicalAppointementBusinessLayer
{

    public static class DependencyConfig
    {
        public static void RegisterDataLayerRepositories(IServiceCollection services)
        {

            // Register Repository (maps IUserRepository → UserRepository)
            services.AddScoped<MedicalAppContext>();
            services.AddScoped<IUserRepository, UserRepository>();
          
        }
    }

}
