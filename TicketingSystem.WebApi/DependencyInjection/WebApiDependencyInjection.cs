using Microsoft.AspNetCore.Identity;
using TicketingSystem.Application.Contracts.Persistance.Context;
using TicketingSystem.Application.DependencyInjection;
using TicketingSystem.Domain.Entities;
using TicketingSystem.Infrastructure.DependencyInjection;
using TicketingSystem.Persistance.Context;
using TicketingSystem.Persistance.DependencyInjection;

namespace TicketingSystem.WebApi.DependencyInjection
{
    public static class WebApiDependencyInjection
    {
        public static void AddWebApiLayerDependencyInjection(this IServiceCollection services, IConfiguration configuration)
        {
            AddPreLayers(services, configuration);
        }
        public static void AddPreLayers(IServiceCollection services, IConfiguration configuration)
        {
            services.AddPersistanceLayerDependencyInjection(configuration);
            services.AddInfrastructureDependencyInjection(configuration);
            services.AddApplicationLayerDependencyInjection();
        }
        public static IServiceCollection AddIentityServices(this IServiceCollection services)
        {
            services
                 .AddIdentity<User, IdentityRole>(options =>
                 {
                     options.Password.RequireUppercase = false;
                     options.Password.RequireLowercase = false;
                     options.Password.RequireNonAlphanumeric = false;
                     options.Password.RequiredLength = 5;

                     options.User.RequireUniqueEmail = true;

                     options.Lockout.MaxFailedAccessAttempts = 3;
                     options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(2);
                 })
                    .AddEntityFrameworkStores<TicketAppDbContext>();
            return services;
        }

        public static IServiceCollection AddCorsServices(this IServiceCollection services, string policyName)
        {
            services.AddCors(options =>
            {
                options.AddPolicy(name: policyName, policy =>
                {
                    policy.AllowAnyOrigin()
                          .AllowAnyHeader()
                          .AllowAnyMethod();
                });
            });
            return services;
        }
    }
}
