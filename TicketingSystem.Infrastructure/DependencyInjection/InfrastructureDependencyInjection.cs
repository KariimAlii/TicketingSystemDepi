using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketingSystem.Application.Contracts.Infrastructure;
using TicketingSystem.Infrastructure.Mail;
using TicketingSystem.Infrastructure.Payment;

namespace TicketingSystem.Infrastructure.DependencyInjection
{
    public static class InfrastructureDependencyInjection
    {
        public static IServiceCollection AddInfrastructureDependencyInjection(this IServiceCollection services, IConfiguration configuration)
        {
            // configuration["Payment"]
            // configuration.GetSection("EmailSettings")
            services.AddScoped<IEmailService, EmailService>();
            services.AddScoped<IPaymentService, PaymentService>();
            return services;
        }
    }
}
