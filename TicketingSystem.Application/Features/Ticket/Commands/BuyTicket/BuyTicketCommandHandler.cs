using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketingSystem.Application.Features.Ticket.Commands.BuyTicket
{
    public class BuyTicketCommandHandler : IRequestHandler<BuyTicketCommandRequest, BuyTicketCommandResponse>
    {
        Task<BuyTicketCommandResponse> IRequestHandler<BuyTicketCommandRequest, BuyTicketCommandResponse>.Handle(BuyTicketCommandRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
