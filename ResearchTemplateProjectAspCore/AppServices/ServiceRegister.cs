
using Microsoft.Extensions.DependencyInjection;
using ResearchTemplateProjectAspCore.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResearchTemplateProjectAspCore.AppServices
{
    static class ServiceRegister
    {
        public static IServiceCollection RegisterAppServices(this IServiceCollection services)
        {
            services.AddTransient<IValueService, ValueService>();

            return services;
        }
    }
}
