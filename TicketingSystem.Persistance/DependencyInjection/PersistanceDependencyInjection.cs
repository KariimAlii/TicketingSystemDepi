using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketingSystem.Persistance.Context;

namespace TicketingSystem.Persistance.DependencyInjection
{
    public static class PersistanceDependencyInjection
    {
        public static IServiceCollection AddPersistanceLayerDependencyInjection(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddHttpContextAccessor();

            services.AddDbContext<TicketAppDbContext>(options =>
            {
                var connectionString = configuration.GetConnectionString("Database");
                options.UseSqlServer(connectionString);
            });

            // Add Repositories

            // Add Unit Of Work

            return services;
        }
    }
}
