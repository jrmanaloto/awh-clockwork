using Clockwork.Business.Interfaces;
using Clockwork.Business.Services;
using Clockwork.Data;
using Microsoft.Extensions.DependencyInjection;

namespace Clockwork.API.App_Start
{
    public class DependencyInjectionConfig
    {
        public static void AddScope(IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<ICurrentTimeService, CurrentTimeService>();
        }

    }
}
