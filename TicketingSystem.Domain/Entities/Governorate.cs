using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketingSystem.Domain.Common;

namespace TicketingSystem.Domain.Entities
{
    public class Governorate : AuditableEntity
    {
        public string GovernorateName { get; set; }
    }
}
