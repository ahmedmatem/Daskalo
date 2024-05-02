using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using static Daskalo.Infrastructure.Data.Configurations.SeedHelper;

namespace Daskalo.Infrastructure.Data.Configurations
{
    public class IdentityRoleEntityTypeConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            SeedRoles();
            builder.HasData(Roles);
        }

        private static void SeedRoles()
        {
            Roles.Clear();
            Roles.Add(new IdentityRole()
            {
                Id = RoleIds["Admin"],
                Name = "Admin",
                NormalizedName = "ADMIN",
                ConcurrencyStamp = RoleIds["Admin"]
            });
            Roles.Add(new IdentityRole()
            {
                Id = RoleIds["SchoolAdmin"],
                Name = "SchoolAdmin",
                NormalizedName = "SCHOOLADMIN",
                ConcurrencyStamp = RoleIds["SchoolAdmin"]
            });
            Roles.Add(new IdentityRole()
            {
                Id = RoleIds["Teacher"],
                Name = "Teacher",
                NormalizedName = "TEACHER",
                ConcurrencyStamp = RoleIds["Teacher"]
            });
        }
    }
}
