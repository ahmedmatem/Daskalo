
using Daskalo.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity;
using static Daskalo.Infrastructure.Data.Constants.AdministratorConstants;

namespace Daskalo.Infrastructure.Data.Configurations
{
    public static class SeedHelper
    {
        public static string SchoolId = Guid.NewGuid().ToString();

        public static IDictionary<string, string> RoleIds =
            new Dictionary<string, string>()
            {
                { "Admin", Guid.NewGuid().ToString() },
                { "SchoolAdmin", Guid.NewGuid().ToString() },
                { "Teacher", Guid.NewGuid().ToString() }
            };

        public static ApplicationUser Admin = CreateAdmin();

        public static readonly IList<School> Schools = new List<School>()
        {
            new School()
            {
                Id = SchoolId,
                Name = "Акад. Никола Обрешков",
                Type = "ППМГ",
                City = "Разград",
                CreatedOn = DateTime.Now,
            },
            new School()
            {
                Name = "Никола Йонков Вапцаров",
                Type = "ОУ",
                City = "Разград",
                CreatedOn = DateTime.Now,
            },
            new School()
            {
                Name = "Екзарх Йосиф",
                Type = "ГПИЧЕ",
                City = "Разград",
                CreatedOn = DateTime.Now,
            },
            new School()
            {
                Name = "Васил Левски",
                Type = "ОУ",
                City = "Разград",
                CreatedOn = DateTime.Now,
            }
        };

        public static ICollection<IdentityRole> Roles = new HashSet<IdentityRole>();

        public static IList<ApplicationUser> Users = new List<ApplicationUser>();

        private static ApplicationUser CreateAdmin()
        {
            PasswordHasher<ApplicationUser> passwordHasher =
                new PasswordHasher<ApplicationUser>();

            var admin = new ApplicationUser()
            {
                Email = AdminEmail,
                NormalizedEmail = AdminEmail.ToUpper(),
                UserName = AdminEmail,
                NormalizedUserName = AdminEmail.ToUpper(),
                FullName = "Ахмед Матем Ахмед",
                Role = Types.Role.Admin,
                SchoolId = SchoolId
            };
            admin.PasswordHash = passwordHasher.HashPassword(admin, "adminPass");

            return admin;
        }
    }
}
