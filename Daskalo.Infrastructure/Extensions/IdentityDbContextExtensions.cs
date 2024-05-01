
using Daskalo.Infrastructure.Data.Contracts;
using Microsoft.EntityFrameworkCore;

namespace Microsoft.AspNetCore.Identity.EntityFrameworkCore
{
    public static class IdentityDbContextExtensions
    {
        public static void ApplyAuditInfoRules(this IdentityDbContext context)
        {
            var auditInfoEntries = context.ChangeTracker.Entries()
                .Where(e => e.Entity is IAuditable &&
                (e.State == EntityState.Modified || e.State == EntityState.Added))
                .ToList();

            foreach (var entry in auditInfoEntries)
            {
                var entity = (DataModel)entry.Entity;
                if (entry.State == EntityState.Added)
                {
                    entity.CreatedOn = DateTime.Now;
                }
                else
                {
                    var dateTimeNow = DateTime.Now;
                    entity.LastModifiedOn = dateTimeNow;
                    if (entry.Entity is IDeletable)
                    {
                        if (((IDeletable)entry.Entity).IsDeleted)
                        {
                            entity.DeletedOn = dateTimeNow;
                        }
                    }
                }
            }
        }
    }
}
