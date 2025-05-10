using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketingSystem.Domain.Entities;

namespace TicketingSystem.Application.Contracts.Persistance.Context
{
    public interface ITicketAppDbContext
    {
        #region Methods
        int SaveChanges();
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
        #endregion
        #region DbSets
        //DbSet<Governorate> Governorates { get; set; }
        #endregion
    }
}
