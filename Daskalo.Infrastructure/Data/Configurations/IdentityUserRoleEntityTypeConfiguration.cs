using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static Daskalo.Infrastructure.Data.Configurations.SeedHelper;

namespace Daskalo.Infrastructure.Data.Configurations
{
    public class IdentityUserRoleEntityTypeConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        private ICollection<IdentityUserRole<string>> usersInRoles
            = new List<IdentityUserRole<string>>();

        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            SeedUserInRole();
            builder.HasData(usersInRoles);
        }

        private void SeedUserInRole()
        {
            usersInRoles.Add(new IdentityUserRole<string>()
            {
                UserId = Admin.Id,
                RoleId = RoleIds["Admin"]
            });
        }
    }
}
