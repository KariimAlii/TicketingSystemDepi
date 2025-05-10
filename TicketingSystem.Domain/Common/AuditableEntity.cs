using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketingSystem.Domain.Common
{
    public class AuditableEntity : IAuditableEntity
    {
        public int Id { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string? CreatedById { get; set; }
        public string? LastModifiedById { get; set; }
    }
}
