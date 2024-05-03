using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Daskalo.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class SetIDeletableUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "77c7dc0e-0509-4779-94f6-86c5c9c8076c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f5ced019-519b-4c6c-a186-cab3c515dfdf");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "73b412ab-43a4-42d8-a09e-a4429a43290f", "f6b7a04c-962e-4f63-93aa-21b8b5321464" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27088276-fa47-44e9-94eb-46e87c328fd2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2cdf7492-10bb-424f-881f-8e820e5c56d6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5dcb673e-2881-4889-92bd-e6752d046313");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "700b5744-c59f-4354-b310-1f1a43f594ed");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "82b35601-4600-42de-91d8-113af52a9c97");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "951e48fa-252c-48a9-b11a-ab5ead777c79");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9c5dc1b0-6667-4a4d-b5b7-bcf80751c5ea");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9ceac608-9747-4d62-8aca-0d3191af100f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9cf77fff-956e-4345-9d9d-cf29f4a64eef");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a39a6063-3c3e-4d14-adea-8cfe664746dc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e49d51c2-1207-401f-b0c6-6847cc5f2163");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ed906163-98c8-430b-a07c-66f2b418e49d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "efdec5af-fce1-4127-b367-7e2edb6ff8f1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f2d3fefd-ad82-420e-8d64-b294583be86b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f2fc4814-32a6-4e79-84b5-658e4c8a88df");

            migrationBuilder.DeleteData(
                table: "School",
                keyColumn: "Id",
                keyValue: "35bdb096-31a5-4051-bb7c-341213875938");

            migrationBuilder.DeleteData(
                table: "School",
                keyColumn: "Id",
                keyValue: "671dbf77-bee1-4908-8ffa-127e215cb43b");

            migrationBuilder.DeleteData(
                table: "School",
                keyColumn: "Id",
                keyValue: "892a9d5b-e3a6-4649-a035-daac2d19096b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73b412ab-43a4-42d8-a09e-a4429a43290f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f6b7a04c-962e-4f63-93aa-21b8b5321464");

            migrationBuilder.DeleteData(
                table: "School",
                keyColumn: "Id",
                keyValue: "286d82c7-09aa-4dd6-9a3a-b7731c647ffc");

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "AspNetUsers",
                type: "bit",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5ea08caf-39a9-445e-9e5f-cb12a533a707", "5ea08caf-39a9-445e-9e5f-cb12a533a707", "Admin", "ADMIN" },
                    { "6d371618-2ced-4429-9429-2643b2a2650c", "6d371618-2ced-4429-9429-2643b2a2650c", "SchoolAdmin", "SCHOOLADMIN" },
                    { "c4ab6e9d-ce41-4d21-bc85-22e18c09996e", "c4ab6e9d-ce41-4d21-bc85-22e18c09996e", "Teacher", "TEACHER" }
                });

            migrationBuilder.InsertData(
                table: "School",
                columns: new[] { "Id", "City", "CreatedOn", "DeletedOn", "IsDeleted", "LastModifiedOn", "Name", "SchoolAdminId", "Type" },
                values: new object[,]
                {
                    { "2f02f960-3723-401e-9d67-02cc4889c78a", "Разград", new DateTime(2024, 5, 3, 15, 53, 36, 932, DateTimeKind.Local).AddTicks(7907), null, false, null, "Акад. Никола Обрешков", null, "ППМГ" },
                    { "740165c4-e6e7-4fc1-882f-33a1c0d00ebb", "Разград", new DateTime(2024, 5, 3, 15, 53, 36, 936, DateTimeKind.Local).AddTicks(8908), null, false, null, "Никола Йонков Вапцаров", null, "ОУ" },
                    { "bc25ab8a-4478-46d3-a44e-0fcf146d0d73", "Разград", new DateTime(2024, 5, 3, 15, 53, 36, 936, DateTimeKind.Local).AddTicks(8944), null, false, null, "Екзарх Йосиф", null, "ГПИЧЕ" },
                    { "ce178b85-8861-4cc1-8462-461010c4136a", "Разград", new DateTime(2024, 5, 3, 15, 53, 36, 936, DateTimeKind.Local).AddTicks(8950), null, false, null, "Васил Левски", null, "ОУ" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DeletedOn", "Discriminator", "Email", "EmailConfirmed", "FullName", "IsDeleted", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Role", "SchoolId", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0a66ad63-f0c2-456e-a0d9-d163325c44eb", 0, "edbf9020-ef25-42eb-a806-c5552c30459a", null, "ApplicationUser", "martin@gmail.com", false, "Мартин Иванов Катев", false, false, null, "MARTIN@GMAIL.COM", "MARTIN@GMAIL.COM", "AQAAAAIAAYagAAAAEDNNunaIA4CfF51a5CmPbFBnyMx2VOG0JJy/qgscd4kIX//FUWWkxozac1CePjPfHA==", null, false, 4, "2f02f960-3723-401e-9d67-02cc4889c78a", "5f562e04-4536-4ee8-9fe5-31eb5b4a11af", false, "martin@gmail.com" },
                    { "0be64273-2bec-499b-85ca-98afa3c33e4b", 0, "fe4e3428-b300-4cef-81da-9eade4fcf24d", null, "ApplicationUser", "daniel@gmail.com", false, "Даниел Г. Христов", false, false, null, "DANIEL@GMAIL.COM", "DANIEL@GMAIL.COM", "AQAAAAIAAYagAAAAEIEwALNnFG9PAMcBNEuKbN14//+KD7R2NTzXub30BSuwPNn1GmVBVnlfm3SBhMa1zw==", null, false, 8, "2f02f960-3723-401e-9d67-02cc4889c78a", "a6bb692c-211f-4f5c-95a3-10ae1250ea23", false, "daniel@gmail.com" },
                    { "12dd5643-4f7c-4447-97bd-5b1880f98a7d", 0, "504e346a-8c24-4a0d-8885-446d1e242480", null, "ApplicationUser", "dani@gmail.com", false, "Даниел П. Петров", false, false, null, "DANI@GMAIL.COM", "DANI@GMAIL.COM", "AQAAAAIAAYagAAAAEIaRZbUee5dlAOS+s7VtDyfnOqlkUaV4eqzp5QeIVXtF7BHBDMfS14QZzkloPQzfSw==", null, false, 8, "2f02f960-3723-401e-9d67-02cc4889c78a", "715a127b-b940-457f-bcde-598cd0ec2010", false, "dani@gmail.com" },
                    { "13327c1c-010e-4dbf-b329-39d351ce2397", 0, "a2422e1b-b4a0-450d-9544-34000afc81cd", null, "ApplicationUser", "admin@mail.com", false, "Ахмед Матем Ахмед", false, false, null, "ADMIN@MAIL.COM", "ADMIN@MAIL.COM", "AQAAAAIAAYagAAAAEMlHpdNbXasHR6XWopjtw4FPINhxCkBAc+pPguOoZAaVl1+R/LdU69x366j0CA/xrw==", null, false, 1, "2f02f960-3723-401e-9d67-02cc4889c78a", "7b3e57dd-cdeb-43d5-8388-18d7220fc83c", false, "admin@mail.com" },
                    { "158c8b55-4609-46de-85d5-d0607385e31a", 0, "bf0cb6e9-78b5-4c65-8ab2-9123967c3dcc", null, "ApplicationUser", "turhan@gmail.com", false, "Турхан Мюмюнов Сюлейманов", false, false, null, "TURHAN@GMAIL.COM", "TURHAN@GMAIL.COM", "AQAAAAIAAYagAAAAEG57DWd1tCZNwOE7z5wA7d71dFD3Jj0WC/JBzt2LjQMVO+Ru6Gt2ZGxrCyCcVWHslQ==", null, false, 4, "2f02f960-3723-401e-9d67-02cc4889c78a", "9c441b7b-21d8-4d42-9b67-d2406520f443", false, "turhan@gmail.com" },
                    { "2e96b8e7-2e43-4414-8099-7c8c8404e1a0", 0, "eddcbe2e-7697-444a-a329-134d487ff54b", null, "ApplicationUser", "ivayla@gmail.com", false, "Ивайла Д. Александрова", false, false, null, "IVAYLA@GMAIL.COM", "IVAYLA@GMAIL.COM", "AQAAAAIAAYagAAAAENW4QZd9/8ACm1ZKozAPoUkpwAloeJjrub3gGRxUGnsITUleGBbzavsXTt0zxod9Qg==", null, false, 8, "2f02f960-3723-401e-9d67-02cc4889c78a", "1001d2b7-fa60-4ce1-9410-fc3c6ec26f84", false, "ivayla@gmail.com" },
                    { "30e3ca89-a114-478e-9347-a07992ae0456", 0, "53466925-c754-452c-985d-16db50620965", null, "ApplicationUser", "venci@gmail.com", false, "Ахмед Матем Ахмед", false, false, null, "VENCI@GMAIL.COM", "VENCI@GMAIL.COM", "AQAAAAIAAYagAAAAEHxvgLAWTsdqTHR7V1MskuRbxVUg5IooV7awU0kmz/ahvyXBHGwJUnJJwGVYB2ghJQ==", null, false, 4, "2f02f960-3723-401e-9d67-02cc4889c78a", "cc41a1e6-300d-4775-9237-3975b52df9d8", false, "venci@gmail.com" },
                    { "34b7fe60-f77a-4b4d-b53d-27a15ead898f", 0, "da711a3d-c059-4ae2-8ffc-b9c1dd8d3987", null, "ApplicationUser", "ivan@gmail.com", false, "Иван Д. Генчев", false, false, null, "IVAN@GMAIL.COM", "IVAN@GMAIL.COM", "AQAAAAIAAYagAAAAEGm+XirHUMELMAzLF4z2vHLXBygwsqe8m/5OMdTqcbLJgyNTqH5XLOrK5r7QTezZCg==", null, false, 8, "2f02f960-3723-401e-9d67-02cc4889c78a", "59acb299-3b85-40a3-a4eb-be8fcb15ee09", false, "ivan@gmail.com" },
                    { "4e86579a-8c1a-439b-af11-e7f89667f53b", 0, "aff9961a-c754-43e2-8c33-54c829397858", null, "ApplicationUser", "ahmed@gmail.com", false, "Ахмед Матем Ахмед", false, false, null, "AHMED@GMAIL.COM", "AHMED@GMAIL.COM", "AQAAAAIAAYagAAAAEGUZ2v4vdsLngYsjrZRX7hq4lerzm8jH23RDdSEq0AfIWiDk0FZGxD2EQR9rj4Zhmw==", null, false, 4, "2f02f960-3723-401e-9d67-02cc4889c78a", "7fcf0878-2d9f-4d9a-a778-a8fcd7b000e0", false, "ahmed@gmail.com" },
                    { "588ac93b-088e-4d0c-a6ec-7a0c2c0157a8", 0, "6cf2c648-b6a2-4b3b-bf6f-fafd719a02fd", null, "ApplicationUser", "dimitar@gmail.com", false, "Димитър Н. Димитров", false, false, null, "DIMITAR@GMAIL.COM", "DIMITAR@GMAIL.COM", "AQAAAAIAAYagAAAAECet+2WQfoF/VslVFwzqlVjqfyZCjjObZRW4Va+wXej+FzDILy4el/Qitb1llUuQ4w==", null, false, 8, "2f02f960-3723-401e-9d67-02cc4889c78a", "85277270-da53-4de2-9636-8b529ff680a7", false, "dimitar@gmail.com" },
                    { "5e6efd70-d8a6-446b-a1d7-a06664f3fa7c", 0, "009b173a-1d46-4f88-8ae7-45e794977edd", null, "ApplicationUser", "viki@gmail.com", false, "Виктория Р. Маркова", false, false, null, "VIKI@GMAIL.COM", "VIKI@GMAIL.COM", "AQAAAAIAAYagAAAAEJ4VWZwG+IIR28dcK6E1CF4OKU9AaYk/x/WP1+CXQ9tNlhCC0clXcOa+QDWufK8ZZw==", null, false, 8, "2f02f960-3723-401e-9d67-02cc4889c78a", "efcfb9a6-1150-4927-841c-d978248b469d", false, "viki@gmail.com" },
                    { "746521fb-a9b7-42b6-812e-a8814ab264b3", 0, "93e6a559-e59e-4248-a39a-743895205dbe", null, "ApplicationUser", "viktoriya@gmail.com", false, "Виктория К. Петкова", false, false, null, "VIKTORIYA@GMAIL.COM", "VIKTORIYA@GMAIL.COM", "AQAAAAIAAYagAAAAELzTc/Ny82TAqkJN42GMjcEOZ7uH2OmHq6iUV45Id8UWIOZPfcnM/jA+mezLmE4WmA==", null, false, 8, "2f02f960-3723-401e-9d67-02cc4889c78a", "d17e8830-b2f8-48c3-982b-3e2f142dec97", false, "viktoriya@gmail.com" },
                    { "7b8e00a7-6b6b-45d6-81d2-ef0f1cde6b5b", 0, "d6a0f916-22c4-4851-9ce0-38589f9bed00", null, "ApplicationUser", "desi@gmail.com", false, "Десислава Иванова Петкова", false, false, null, "DESI@GMAIL.COM", "DESI@GMAIL.COM", "AQAAAAIAAYagAAAAEBPtDKYlGrw0vb4ckDeYGUj7Outh2EiAskfzHHs+7H4m+j5ClpRTmNTdZ1xo0p57/A==", null, false, 4, "2f02f960-3723-401e-9d67-02cc4889c78a", "1fbdaaee-5ccd-4aaf-a42a-5fb262d8f374", false, "desi@gmail.com" },
                    { "9919e9c2-6514-434c-a8ba-703b253c189c", 0, "245ad94b-d590-487a-9c4f-1ece6de3dce0", null, "ApplicationUser", "dimana@gmail.com", false, "Димана В. Кънчева", false, false, null, "DIMANA@GMAIL.COM", "DIMANA@GMAIL.COM", "AQAAAAIAAYagAAAAEBO8fARkF+xrfbCrZxPd3TBqPjKSIjWdZvznfHOIXkeAZ+osMOlge/k9mNLTUenMqw==", null, false, 8, "2f02f960-3723-401e-9d67-02cc4889c78a", "1877991b-b589-4243-affd-61a4f4249879", false, "dimana@gmail.com" },
                    { "a3e7f1c6-b765-4b9e-b6b9-c2e0bef25a54", 0, "cd18662e-113b-44ad-aff8-3c1ca795da79", null, "ApplicationUser", "baran@gmail.com", false, "Баран Б. Бехчет", false, false, null, "BARAN@GMAIL.COM", "BARAN@GMAIL.COM", "AQAAAAIAAYagAAAAELi86Fqrjvsxivb+fLDHG2cSxGIm70UzYQUO0q3GBoqypB0lXmHgNWOr0H8u8BmKFg==", null, false, 8, "2f02f960-3723-401e-9d67-02cc4889c78a", "c413305e-f849-472c-97ce-d03f7d71351d", false, "baran@gmail.com" },
                    { "e0c559ab-a96f-4b75-b896-5caea2bbd098", 0, "2783094c-73f8-4a47-bf80-fb3336ff4fa7", null, "ApplicationUser", "emre@gmail.com", false, "Емре Е. Хюсеин", false, false, null, "EMRE@GMAIL.COM", "EMRE@GMAIL.COM", "AQAAAAIAAYagAAAAECr/O9ANitpZeEun+cksYnkK1Q2rcKg4IKyjF4YGkeEOrLnCjzcDdKPkg0BTXW1lZQ==", null, false, 8, "2f02f960-3723-401e-9d67-02cc4889c78a", "8465de80-f7cb-4fe4-b000-3b4bb6bcb20b", false, "emre@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "5ea08caf-39a9-445e-9e5f-cb12a533a707", "13327c1c-010e-4dbf-b329-39d351ce2397" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6d371618-2ced-4429-9429-2643b2a2650c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c4ab6e9d-ce41-4d21-bc85-22e18c09996e");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5ea08caf-39a9-445e-9e5f-cb12a533a707", "13327c1c-010e-4dbf-b329-39d351ce2397" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0a66ad63-f0c2-456e-a0d9-d163325c44eb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0be64273-2bec-499b-85ca-98afa3c33e4b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12dd5643-4f7c-4447-97bd-5b1880f98a7d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "158c8b55-4609-46de-85d5-d0607385e31a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2e96b8e7-2e43-4414-8099-7c8c8404e1a0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30e3ca89-a114-478e-9347-a07992ae0456");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "34b7fe60-f77a-4b4d-b53d-27a15ead898f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4e86579a-8c1a-439b-af11-e7f89667f53b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "588ac93b-088e-4d0c-a6ec-7a0c2c0157a8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5e6efd70-d8a6-446b-a1d7-a06664f3fa7c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "746521fb-a9b7-42b6-812e-a8814ab264b3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7b8e00a7-6b6b-45d6-81d2-ef0f1cde6b5b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9919e9c2-6514-434c-a8ba-703b253c189c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a3e7f1c6-b765-4b9e-b6b9-c2e0bef25a54");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e0c559ab-a96f-4b75-b896-5caea2bbd098");

            migrationBuilder.DeleteData(
                table: "School",
                keyColumn: "Id",
                keyValue: "740165c4-e6e7-4fc1-882f-33a1c0d00ebb");

            migrationBuilder.DeleteData(
                table: "School",
                keyColumn: "Id",
                keyValue: "bc25ab8a-4478-46d3-a44e-0fcf146d0d73");

            migrationBuilder.DeleteData(
                table: "School",
                keyColumn: "Id",
                keyValue: "ce178b85-8861-4cc1-8462-461010c4136a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5ea08caf-39a9-445e-9e5f-cb12a533a707");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13327c1c-010e-4dbf-b329-39d351ce2397");

            migrationBuilder.DeleteData(
                table: "School",
                keyColumn: "Id",
                keyValue: "2f02f960-3723-401e-9d67-02cc4889c78a");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "73b412ab-43a4-42d8-a09e-a4429a43290f", "73b412ab-43a4-42d8-a09e-a4429a43290f", "Admin", "ADMIN" },
                    { "77c7dc0e-0509-4779-94f6-86c5c9c8076c", "77c7dc0e-0509-4779-94f6-86c5c9c8076c", "Teacher", "TEACHER" },
                    { "f5ced019-519b-4c6c-a186-cab3c515dfdf", "f5ced019-519b-4c6c-a186-cab3c515dfdf", "SchoolAdmin", "SCHOOLADMIN" }
                });

            migrationBuilder.InsertData(
                table: "School",
                columns: new[] { "Id", "City", "CreatedOn", "DeletedOn", "IsDeleted", "LastModifiedOn", "Name", "SchoolAdminId", "Type" },
                values: new object[,]
                {
                    { "286d82c7-09aa-4dd6-9a3a-b7731c647ffc", "Разград", new DateTime(2024, 5, 2, 23, 4, 41, 232, DateTimeKind.Local).AddTicks(765), null, false, null, "Акад. Никола Обрешков", null, "ППМГ" },
                    { "35bdb096-31a5-4051-bb7c-341213875938", "Разград", new DateTime(2024, 5, 2, 23, 4, 41, 235, DateTimeKind.Local).AddTicks(3113), null, false, null, "Никола Йонков Вапцаров", null, "ОУ" },
                    { "671dbf77-bee1-4908-8ffa-127e215cb43b", "Разград", new DateTime(2024, 5, 2, 23, 4, 41, 235, DateTimeKind.Local).AddTicks(3168), null, false, null, "Васил Левски", null, "ОУ" },
                    { "892a9d5b-e3a6-4649-a035-daac2d19096b", "Разград", new DateTime(2024, 5, 2, 23, 4, 41, 235, DateTimeKind.Local).AddTicks(3162), null, false, null, "Екзарх Йосиф", null, "ГПИЧЕ" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Role", "SchoolId", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "27088276-fa47-44e9-94eb-46e87c328fd2", 0, "33c64d79-d981-44dc-b7bc-d62b21e55bbd", "ApplicationUser", "dimana@gmail.com", false, "Димана В. Кънчева", false, null, "DIMANA@GMAIL.COM", "DIMANA@GMAIL.COM", "AQAAAAIAAYagAAAAEDMK+ad5+vJzS4YKadhWnC0lE9AEYiQTONxn94UuDWpSGOUgHtbkriDaYEkRF7G/vQ==", null, false, 8, "286d82c7-09aa-4dd6-9a3a-b7731c647ffc", "afe17e63-6c14-4fcb-8db2-a4795c768aac", false, "dimana@gmail.com" },
                    { "2cdf7492-10bb-424f-881f-8e820e5c56d6", 0, "bfb25361-cb46-4d3c-8190-6058c3e45a59", "ApplicationUser", "baran@gmail.com", false, "Баран Б. Бехчет", false, null, "BARAN@GMAIL.COM", "BARAN@GMAIL.COM", "AQAAAAIAAYagAAAAEIB5M5KGy1DJLEyPKF0XWa86ahgKRYszcKUUE2DU3hdd3OQZdIHwjGXybwkCJ8oagA==", null, false, 8, "286d82c7-09aa-4dd6-9a3a-b7731c647ffc", "e596ddcc-7b30-438c-9108-7cc82f2115e2", false, "baran@gmail.com" },
                    { "5dcb673e-2881-4889-92bd-e6752d046313", 0, "7804a62a-dec5-46f9-8e7a-0f3b3e5a632a", "ApplicationUser", "venci@gmail.com", false, "Ахмед Матем Ахмед", false, null, "VENCI@GMAIL.COM", "VENCI@GMAIL.COM", "AQAAAAIAAYagAAAAECNOSaO7FiDpU+EwVb7O+NtCuPPaf/s+EQvJ4/6qYThSy+93YDypCadIwkb9hKGRMg==", null, false, 4, "286d82c7-09aa-4dd6-9a3a-b7731c647ffc", "fd4226e0-d9ec-4bd3-a915-df5c5d00a76c", false, "venci@gmail.com" },
                    { "700b5744-c59f-4354-b310-1f1a43f594ed", 0, "eceae4ee-b85c-4054-a45e-5a9ded379ef1", "ApplicationUser", "dimitar@gmail.com", false, "Димитър Н. Димитров", false, null, "DIMITAR@GMAIL.COM", "DIMITAR@GMAIL.COM", "AQAAAAIAAYagAAAAEM3WHE1v5snI2OvSfGTrZihOEV0G6zE0m0QJ7iFErDv1VdHygjLqyAPUDB5jK+gznA==", null, false, 8, "286d82c7-09aa-4dd6-9a3a-b7731c647ffc", "48a7540a-268e-48c0-a871-af09c26541e2", false, "dimitar@gmail.com" },
                    { "82b35601-4600-42de-91d8-113af52a9c97", 0, "1722ef9f-705a-47f5-8d5b-9dc26642d935", "ApplicationUser", "emre@gmail.com", false, "Емре Е. Хюсеин", false, null, "EMRE@GMAIL.COM", "EMRE@GMAIL.COM", "AQAAAAIAAYagAAAAEG55gt91osxKhNlzBMdwvRgc006ImwUbUDyJeNBaZCZ+dpze9wkuaOeGYaHHwYoC2w==", null, false, 8, "286d82c7-09aa-4dd6-9a3a-b7731c647ffc", "2e7a64bb-3661-4287-a867-4d1039e92cbf", false, "emre@gmail.com" },
                    { "951e48fa-252c-48a9-b11a-ab5ead777c79", 0, "4e2fc312-1ac1-4ad7-ad3f-502e3c495092", "ApplicationUser", "viki@gmail.com", false, "Виктория Р. Маркова", false, null, "VIKI@GMAIL.COM", "VIKI@GMAIL.COM", "AQAAAAIAAYagAAAAEM9C0TtzbPCwBgzvzSEGzTCCcLJH3d5qyyzoDpExWp/uJVNDL7wRhHU7DLOBxxDztA==", null, false, 8, "286d82c7-09aa-4dd6-9a3a-b7731c647ffc", "5bfa6a78-88be-43ad-94e6-2f2aab150fc1", false, "viki@gmail.com" },
                    { "9c5dc1b0-6667-4a4d-b5b7-bcf80751c5ea", 0, "dd6c36f6-116c-4ed0-a847-396e6953b564", "ApplicationUser", "turhan@gmail.com", false, "Турхан Мюмюнов Сюлейманов", false, null, "TURHAN@GMAIL.COM", "TURHAN@GMAIL.COM", "AQAAAAIAAYagAAAAEFA09Pd3z6IPqeCtIbVX6Saso+/BUEy6fiIL/1iL/V3gfWEmHdrSqVLoPn7ic0URDQ==", null, false, 4, "286d82c7-09aa-4dd6-9a3a-b7731c647ffc", "d3252ad6-444e-444d-8fcc-06f54894d558", false, "turhan@gmail.com" },
                    { "9ceac608-9747-4d62-8aca-0d3191af100f", 0, "0eb40e98-a76b-4506-be56-a1cce43a1ba1", "ApplicationUser", "daniel@gmail.com", false, "Даниел Г. Христов", false, null, "DANIEL@GMAIL.COM", "DANIEL@GMAIL.COM", "AQAAAAIAAYagAAAAEMS/79KIiOA8n7ROM/bSmNHKg3yZJxOv43cdF54vmuKGu810A6H7p6JiLDl65V1DjQ==", null, false, 8, "286d82c7-09aa-4dd6-9a3a-b7731c647ffc", "baefd265-4b67-4408-bd8c-b7dab21f55dd", false, "daniel@gmail.com" },
                    { "9cf77fff-956e-4345-9d9d-cf29f4a64eef", 0, "b0c60bc6-0b21-47df-8f18-5370d09541fc", "ApplicationUser", "dani@gmail.com", false, "Даниел П. Петров", false, null, "DANI@GMAIL.COM", "DANI@GMAIL.COM", "AQAAAAIAAYagAAAAEKb3oVbMMSRx6utLrxZQue4X3DW8E0F9UpZpgseBLfwkseSGP+n9NA8Ma8xtWlqUoA==", null, false, 8, "286d82c7-09aa-4dd6-9a3a-b7731c647ffc", "9675288c-3249-4aac-9e3b-94c944915e6c", false, "dani@gmail.com" },
                    { "a39a6063-3c3e-4d14-adea-8cfe664746dc", 0, "609cf3d2-2d2c-41b9-a87e-50566034c441", "ApplicationUser", "ivan@gmail.com", false, "Иван Д. Генчев", false, null, "IVAN@GMAIL.COM", "IVAN@GMAIL.COM", "AQAAAAIAAYagAAAAECCZGxwk0uFl0VL1cK2bi/pOoXsqL8JwPG7Dr0EuBLlnaR0FgwrbUzTmzwZzcfQnLA==", null, false, 8, "286d82c7-09aa-4dd6-9a3a-b7731c647ffc", "fe50cb04-36a0-467f-bfe2-3b30d32ba7a5", false, "ivan@gmail.com" },
                    { "e49d51c2-1207-401f-b0c6-6847cc5f2163", 0, "3dddc470-d0ba-4387-939a-73b2d6921390", "ApplicationUser", "ivayla@gmail.com", false, "Ивайла Д. Александрова", false, null, "IVAYLA@GMAIL.COM", "IVAYLA@GMAIL.COM", "AQAAAAIAAYagAAAAENXtxlsIkNXtaKO45BvoSj0NnH9nPuFrYFw5kC3WUwFy3ea07JCzaszBWhA0vbd69Q==", null, false, 8, "286d82c7-09aa-4dd6-9a3a-b7731c647ffc", "5ebad8dd-4dc6-47e7-8119-2825c9b78c8a", false, "ivayla@gmail.com" },
                    { "ed906163-98c8-430b-a07c-66f2b418e49d", 0, "0c688e4d-e0f9-4760-80c8-721ce144d361", "ApplicationUser", "ahmed@gmail.com", false, "Ахмед Матем Ахмед", false, null, "AHMED@GMAIL.COM", "AHMED@GMAIL.COM", "AQAAAAIAAYagAAAAENG2dz9za4YqqiakWjuWPTOLSAmaCgKp2/iTDkKc2V1Baa5iqJUUqWV+w0YrggxYSA==", null, false, 4, "286d82c7-09aa-4dd6-9a3a-b7731c647ffc", "48a2fcc3-0098-4382-aeef-aad2d3cc16db", false, "ahmed@gmail.com" },
                    { "efdec5af-fce1-4127-b367-7e2edb6ff8f1", 0, "eaa81923-a351-4e3c-902a-d2840895396e", "ApplicationUser", "martin@gmail.com", false, "Мартин Иванов Катев", false, null, "MARTIN@GMAIL.COM", "MARTIN@GMAIL.COM", "AQAAAAIAAYagAAAAEO3wQE2SznQqnFeQh5s8ujFlT7a67ujEpDQPPnd4muqYfdXI35ttOUWOdsqg23f5Wg==", null, false, 4, "286d82c7-09aa-4dd6-9a3a-b7731c647ffc", "930a48fc-f291-4bf4-b34b-9cfcdd854b08", false, "martin@gmail.com" },
                    { "f2d3fefd-ad82-420e-8d64-b294583be86b", 0, "8f9a3199-4291-4931-932f-cb0e812f1d13", "ApplicationUser", "desi@gmail.com", false, "Десислава Иванова Петкова", false, null, "DESI@GMAIL.COM", "DESI@GMAIL.COM", "AQAAAAIAAYagAAAAEMamdeNmrqBxi31s84BplEF68xfXL7Vxy02nn1FxwcOsGH64vcPWOh1enVihBkxzog==", null, false, 4, "286d82c7-09aa-4dd6-9a3a-b7731c647ffc", "0032f347-5284-45f0-9094-f3a5cb26e20c", false, "desi@gmail.com" },
                    { "f2fc4814-32a6-4e79-84b5-658e4c8a88df", 0, "1d9e6062-8cb5-49c5-bf3e-64ce56e94b69", "ApplicationUser", "viktoriya@gmail.com", false, "Виктория К. Петкова", false, null, "VIKTORIYA@GMAIL.COM", "VIKTORIYA@GMAIL.COM", "AQAAAAIAAYagAAAAENBJhByjvJs6N6cBfu0AAWPalRxAFokUzzv5PzWHpvh8aAQSQfsxdagTJyMzjp6k2Q==", null, false, 8, "286d82c7-09aa-4dd6-9a3a-b7731c647ffc", "2f360132-e92e-463a-af61-78b3954cd6ec", false, "viktoriya@gmail.com" },
                    { "f6b7a04c-962e-4f63-93aa-21b8b5321464", 0, "dddfcfb3-704c-4c15-b09c-4b1e568c60cd", "ApplicationUser", "admin@mail.com", false, "Ахмед Матем Ахмед", false, null, "ADMIN@MAIL.COM", "ADMIN@MAIL.COM", "AQAAAAIAAYagAAAAELH7mq3pPLxqpp7bE8aEFQ9Qv0PP73MydyXv6+F8NQ6wpOjehxKnt8IdCnYSuZuvAw==", null, false, 1, "286d82c7-09aa-4dd6-9a3a-b7731c647ffc", "472d236a-f924-4245-a172-884ac5367b6d", false, "admin@mail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "73b412ab-43a4-42d8-a09e-a4429a43290f", "f6b7a04c-962e-4f63-93aa-21b8b5321464" });
        }
    }
}
