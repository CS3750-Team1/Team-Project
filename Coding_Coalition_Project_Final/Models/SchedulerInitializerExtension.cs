using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Coding_Coalition_Project.Data;

namespace Coding_Coalition_Project.Models
{
    public static class SchedulerInitializerExtension
    {
        public static IWebHost InitializeDatabase(this IWebHost webHost)
        {
            var serviceScopeFactory =
            (IServiceScopeFactory)webHost.Services.GetService(typeof(IServiceScopeFactory));

            using (var scope = serviceScopeFactory.CreateScope())
            {
                var services = scope.ServiceProvider;
                var dbContext = services.GetRequiredService<Coding_Coalition_ProjectContext>();
                dbContext.Database.EnsureCreated();
                SchedulerSeeder.Seed(dbContext);
            }

            return webHost;
        }
    }
}
