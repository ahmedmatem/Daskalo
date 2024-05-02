using Daskalo.Infrastructure.Data.Models;
using Daskalo.Infrastructure.Data.Types;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static Daskalo.Infrastructure.Data.Configurations.SeedHelper;

namespace Daskalo.Infrastructure.Data.Configurations
{
    public class IdentityEntityTypeConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        private readonly PasswordHasher<ApplicationUser> passwordHasher
            = new PasswordHasher<ApplicationUser>();

        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            SeedUsers();
            builder.HasData(Users);
        }

        private void SeedUsers()
        {
            Users.Clear();
            Users.Add(Admin);

            Users.Add(CreateUser("ahmed@gmail.com", "ahmedPass", "Ахмед Матем Ахмед", Role.Teacher));
            Users.Add(CreateUser("turhan@gmail.com", "turhanPass", "Турхан Мюмюнов Сюлейманов", Role.Teacher));
            Users.Add(CreateUser("martin@gmail.com", "martinPass", "Мартин Иванов Катев", Role.Teacher));
            Users.Add(CreateUser("desi@gmail.com", "desiPass", "Десислава Иванова Петкова", Role.Teacher));
            Users.Add(CreateUser("venci@gmail.com", "venciPass", "Ахмед Матем Ахмед", Role.Teacher));

            Users.Add(CreateUser("baran@gmail.com", "baranPass", "Баран Б. Бехчет", Role.Student));
            Users.Add(CreateUser("viktoriya@gmail.com", "viktoriyaPass", "Виктория К. Петкова", Role.Student));
            Users.Add(CreateUser("viki@gmail.com", "vikiPass", "Виктория Р. Маркова", Role.Student));
            Users.Add(CreateUser("daniel@gmail.com", "danielPass", "Даниел Г. Христов", Role.Student));
            Users.Add(CreateUser("dani@gmail.com", "daniPass", "Даниел П. Петров", Role.Student));
            Users.Add(CreateUser("dimana@gmail.com", "dimanaPass", "Димана В. Кънчева", Role.Student));
            Users.Add(CreateUser("dimitar@gmail.com", "dimitarPass", "Димитър Н. Димитров", Role.Student));
            Users.Add(CreateUser("emre@gmail.com", "emrePass", "Емре Е. Хюсеин", Role.Student));
            Users.Add(CreateUser("ivayla@gmail.com", "ivaylaPass", "Ивайла Д. Александрова", Role.Student));
            Users.Add(CreateUser("ivan@gmail.com", "ivanPass", "Иван Д. Генчев", Role.Student));
        }

        private ApplicationUser CreateUser(
            string email,
            string password,
            string fullName,
            Role role)
        {
            var user = new ApplicationUser()
            {
                Email = email,
                NormalizedEmail = email.ToUpper(),
                UserName = email,
                NormalizedUserName = email.ToUpper(),
                FullName = fullName,
                Role = role,
                SchoolId = SchoolId,
            };
            user.PasswordHash = passwordHasher.HashPassword(user, password);

            return user;
        }
    }
}
