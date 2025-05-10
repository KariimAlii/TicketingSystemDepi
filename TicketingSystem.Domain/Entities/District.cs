using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketingSystem.Domain.Common;

namespace TicketingSystem.Domain.Entities
{
    public class District : AuditableEntity
    {
        public int DistrictName { get; set; }
    }
}
