using Clockwork.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;

namespace Clockwork.API.App_Start
{
    public class DBContextConfig
    {
        public static void Initialize(IServiceCollection services)
        {

            services.AddDbContextPool<ClockworkContext>(options => options.UseSqlite(
                $"Data Source={Path.Combine(Environment.CurrentDirectory.Replace(".API", ".Data"), @"clockwork.db")}",
                sqlServerOptions =>
                {
                    sqlServerOptions.MigrationsAssembly("Clockwork.API");
                }));
        }
    }
}
