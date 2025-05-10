using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketingSystem.Domain.Common;
using TicketingSystem.Domain.Entities;

namespace TicketingSystem.Persistance.Context
{
    public class TicketAppDbContext : IdentityDbContext<User>
    {
        public DbSet<Governorate> Governorates { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public TicketAppDbContext(DbContextOptions<TicketAppDbContext> options) : base(options)
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer("");
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(typeof(TicketAppDbContext).Assembly);
            base.OnModelCreating(builder);
        }
        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            foreach (var entry in ChangeTracker.Entries())
            {
                if(entry.Entity is IAuditableEntity auditableEntity)
                {
                    if(entry.State == EntityState.Added)
                    {
                        auditableEntity.CreatedById = ""; // current user id
                        auditableEntity.CreatedDate = DateTime.UtcNow;
                    }
                    else if(entry.State == EntityState.Modified)
                    {
                        auditableEntity.LastModifiedById = "";
                        auditableEntity.LastModifiedDate = DateTime.UtcNow;
                    }
                }
            }
            return await base.SaveChangesAsync(cancellationToken);
        }
    }
}
