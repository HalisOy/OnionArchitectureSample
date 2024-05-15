using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public static class CoreModule
    {
        public static void CoreModuleLoad(this IServiceCollection services)
        {
            services.AddScoped<IClassTest, ClassTest>();
        }
    }
}
