using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TicketingSystem.Domain.Common;

namespace TicketingSystem.Domain.Entities
{
    public class Ticket : AuditableEntity
    {
        public string Status { get; set; }
        public string PhoneNumber { get; set; }

        public int CityId { get; set; }
        public int GovernorateId { get; set; }
        public int DistrictId { get; set; }
    }
}
