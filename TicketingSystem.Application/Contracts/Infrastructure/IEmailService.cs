using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketingSystem.Application.Contracts.Infrastructure
{
    public interface IEmailService
    {
        Task SendEmail();
    }
}
