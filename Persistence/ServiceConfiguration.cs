using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    public static class ServiceConfiguration
    {
        public static void AddPersistence(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<HomeAssistantDeviceContext>();
        }
    }
}
