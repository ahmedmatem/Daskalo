using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Daskalo.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class SetRoleFlags : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1825fe4f-38f5-49c6-b5e5-93121d91b541");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "25e0c93c-b7c3-4f2f-8a25-716b92047522");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e7557676-0429-43b7-8e91-83caf6b739a2", "bac209f5-c786-4b72-8ca4-9099bba9085b" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1cd8e759-b2ac-422b-a8a2-ec085f052ed5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1cecd217-a02c-4b4d-8c36-1024ef36df90");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3cc5c698-b1d0-440a-8f2a-496436f3ed8d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "493b59a6-290f-424c-a733-fc43712f5ab4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5ad9dc51-dad1-40f9-b060-c50f3b5acad1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79fb1a05-fa56-4e5c-9f46-4fcd9ce1181b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8495638b-be7e-41cd-b473-befe2b80f61b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "888c0487-c196-47af-a207-5aa71ae38b44");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "90b6c754-e41a-4794-a7ac-e0cde40f372b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1b573df-e30a-4991-bcc6-66167a7cf595");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a3bcfd03-9bc9-4d98-9436-09f1bc813797");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e1e5c760-ec84-4abc-b9f3-cc79835a3aac");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e43e1471-254c-4a12-b755-dc80fb1d2224");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ea3aa364-fffc-493f-938e-222f0068a745");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fbb3e516-0ec3-4652-9731-daed5b9a2594");

            migrationBuilder.DeleteData(
                table: "School",
                keyColumn: "Id",
                keyValue: "683358ad-2f85-4631-8c64-517bf0a70c6a");

            migrationBuilder.DeleteData(
                table: "School",
                keyColumn: "Id",
                keyValue: "a53b255c-dabc-49d5-a2c5-6f890725f612");

            migrationBuilder.DeleteData(
                table: "School",
                keyColumn: "Id",
                keyValue: "c164aec3-d77b-4ef7-853e-3cfb8bb5b156");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e7557676-0429-43b7-8e91-83caf6b739a2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bac209f5-c786-4b72-8ca4-9099bba9085b");

            migrationBuilder.DeleteData(
                table: "School",
                keyColumn: "Id",
                keyValue: "4ac5d0f7-e63f-4754-aa31-bb42a973fe0d");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1825fe4f-38f5-49c6-b5e5-93121d91b541", "1825fe4f-38f5-49c6-b5e5-93121d91b541", "Teacher", "TEACHER" },
                    { "25e0c93c-b7c3-4f2f-8a25-716b92047522", "25e0c93c-b7c3-4f2f-8a25-716b92047522", "SchoolAdmin", "SCHOOLADMIN" },
                    { "e7557676-0429-43b7-8e91-83caf6b739a2", "e7557676-0429-43b7-8e91-83caf6b739a2", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "School",
                columns: new[] { "Id", "City", "CreatedOn", "DeletedOn", "IsDeleted", "LastModifiedOn", "Name", "SchoolAdminId", "Type" },
                values: new object[,]
                {
                    { "4ac5d0f7-e63f-4754-aa31-bb42a973fe0d", "Разград", new DateTime(2024, 5, 2, 22, 47, 32, 836, DateTimeKind.Local).AddTicks(5274), null, false, null, "Акад. Никола Обрешков", null, "ППМГ" },
                    { "683358ad-2f85-4631-8c64-517bf0a70c6a", "Разград", new DateTime(2024, 5, 2, 22, 47, 32, 839, DateTimeKind.Local).AddTicks(9492), null, false, null, "Никола Йонков Вапцаров", null, "ОУ" },
                    { "a53b255c-dabc-49d5-a2c5-6f890725f612", "Разград", new DateTime(2024, 5, 2, 22, 47, 32, 839, DateTimeKind.Local).AddTicks(9610), null, false, null, "Васил Левски", null, "ОУ" },
                    { "c164aec3-d77b-4ef7-853e-3cfb8bb5b156", "Разград", new DateTime(2024, 5, 2, 22, 47, 32, 839, DateTimeKind.Local).AddTicks(9596), null, false, null, "Екзарх Йосиф", null, "ГПИЧЕ" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Role", "SchoolId", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1cd8e759-b2ac-422b-a8a2-ec085f052ed5", 0, "842f33bd-866a-43f4-90bc-59663c2fde30", "ApplicationUser", "ahmed@gmail.com", false, "Ахмед Матем Ахмед", false, null, "AHMED@GMAIL.COM", "AHMED@GMAIL.COM", "AQAAAAIAAYagAAAAECGLCYeT6OFYjtqCf0lFZ7Gg6LEW2e7wjPzVv17Z+V/hyaqSLvwx4fBZ8XpvVKKR3w==", null, false, 2, "4ac5d0f7-e63f-4754-aa31-bb42a973fe0d", "af53859a-da36-476b-8b96-6e05fe8fb510", false, "ahmed@gmail.com" },
                    { "1cecd217-a02c-4b4d-8c36-1024ef36df90", 0, "90c74b5d-2843-4d78-a5eb-52b4efa79894", "ApplicationUser", "ivayla@gmail.com", false, "Ивайла Д. Александрова", false, null, "IVAYLA@GMAIL.COM", "IVAYLA@GMAIL.COM", "AQAAAAIAAYagAAAAEJqQ/sZZ+T/DvKPMiOLj0mJF1m0aAvXRiwK61gHTx+K3A6fnD93urBTZ/6DJnku/nQ==", null, false, 3, "4ac5d0f7-e63f-4754-aa31-bb42a973fe0d", "681664ee-f844-40a1-a1e8-13082e02fd12", false, "ivayla@gmail.com" },
                    { "3cc5c698-b1d0-440a-8f2a-496436f3ed8d", 0, "6845770a-bba3-4538-8ae1-7c38d55553c0", "ApplicationUser", "dani@gmail.com", false, "Даниел П. Петров", false, null, "DANI@GMAIL.COM", "DANI@GMAIL.COM", "AQAAAAIAAYagAAAAEPCO9YmKOS02g7uXFBqJ0kYFgaVRQeyXt1zPlkU70pn/Ym/2hOH9dULuh/Kn2IGCCg==", null, false, 3, "4ac5d0f7-e63f-4754-aa31-bb42a973fe0d", "71adc8ef-5b62-413d-8855-b871741e6c55", false, "dani@gmail.com" },
                    { "493b59a6-290f-424c-a733-fc43712f5ab4", 0, "de0b407a-712a-4340-9eaf-ce130f45c4db", "ApplicationUser", "viktoriya@gmail.com", false, "Виктория К. Петкова", false, null, "VIKTORIYA@GMAIL.COM", "VIKTORIYA@GMAIL.COM", "AQAAAAIAAYagAAAAEFnOxpHtLepRFlBqR/Uv08htf996kEAjrking3hMbtn/MRovr0PewIapyl8jtYPImw==", null, false, 3, "4ac5d0f7-e63f-4754-aa31-bb42a973fe0d", "301c9429-4935-4e7b-8343-0c37ee314fe4", false, "viktoriya@gmail.com" },
                    { "5ad9dc51-dad1-40f9-b060-c50f3b5acad1", 0, "551d216b-334a-4d7e-a2e5-8b4a6c992dca", "ApplicationUser", "viki@gmail.com", false, "Виктория Р. Маркова", false, null, "VIKI@GMAIL.COM", "VIKI@GMAIL.COM", "AQAAAAIAAYagAAAAEIIt3Y6qxIiO0bKQcpTRm2DuJ0BoQonAqCsgAZjJglE7Op6adpoN4u5MpoPx/kQNdQ==", null, false, 3, "4ac5d0f7-e63f-4754-aa31-bb42a973fe0d", "6dd6755e-3baf-4037-a49a-bc452a4fbfe5", false, "viki@gmail.com" },
                    { "79fb1a05-fa56-4e5c-9f46-4fcd9ce1181b", 0, "f027ba53-f637-4216-b8f9-b2d9420c0bef", "ApplicationUser", "turhan@gmail.com", false, "Турхан Мюмюнов Сюлейманов", false, null, "TURHAN@GMAIL.COM", "TURHAN@GMAIL.COM", "AQAAAAIAAYagAAAAEMz48jOtzdxelLEnmp9/zMC04mBIyIIOojhBY8oGyu2JsnDEixfXw8J7jrA3YkmH6Q==", null, false, 2, "4ac5d0f7-e63f-4754-aa31-bb42a973fe0d", "5821ae0f-4c2a-43bf-86ed-8fb3e9065a93", false, "turhan@gmail.com" },
                    { "8495638b-be7e-41cd-b473-befe2b80f61b", 0, "b59c2902-1fa4-4c48-a13d-63a3c850cc61", "ApplicationUser", "martin@gmail.com", false, "Мартин Иванов Катев", false, null, "MARTIN@GMAIL.COM", "MARTIN@GMAIL.COM", "AQAAAAIAAYagAAAAEOmazqWpG6fYrSMjQO8QZ1CKpXBjE2Vo0xkW2zEs8fhSxnL8pCWOfyZAbhcXnaFMkg==", null, false, 2, "4ac5d0f7-e63f-4754-aa31-bb42a973fe0d", "c4a6e731-dd98-4f2b-bca4-8dd549ba97a0", false, "martin@gmail.com" },
                    { "888c0487-c196-47af-a207-5aa71ae38b44", 0, "62ddad09-6d37-4902-a361-2b116f945855", "ApplicationUser", "daniel@gmail.com", false, "Даниел Г. Христов", false, null, "DANIEL@GMAIL.COM", "DANIEL@GMAIL.COM", "AQAAAAIAAYagAAAAEELqAxNZz7unj5kde5O5lbtXzYJr+UZKUPXJgrVGcC6tmB04CsKV6broKvQAjBwPrw==", null, false, 3, "4ac5d0f7-e63f-4754-aa31-bb42a973fe0d", "3df9d43b-10b5-4fc3-9dca-ef9cd37aca19", false, "daniel@gmail.com" },
                    { "90b6c754-e41a-4794-a7ac-e0cde40f372b", 0, "e7163ad7-66d0-46f6-8a41-b57555533217", "ApplicationUser", "desi@gmail.com", false, "Десислава Иванова Петкова", false, null, "DESI@GMAIL.COM", "DESI@GMAIL.COM", "AQAAAAIAAYagAAAAEJNDFyDB7IJASSiPL7f6Yot1SkEUBnLuVzFqwVerrUOLeCz3Um36dWKTJKP96CEjgA==", null, false, 2, "4ac5d0f7-e63f-4754-aa31-bb42a973fe0d", "9654d093-dc12-47b6-80d0-5d67c75f3d2b", false, "desi@gmail.com" },
                    { "a1b573df-e30a-4991-bcc6-66167a7cf595", 0, "51e2f41d-ccf2-48d8-a179-c9d44ad1420b", "ApplicationUser", "baran@gmail.com", false, "Баран Б. Бехчет", false, null, "BARAN@GMAIL.COM", "BARAN@GMAIL.COM", "AQAAAAIAAYagAAAAEI7aq6WVfbk09HorLmX0tqPT4Ygod6f3eGXT+5LroWa+VyuDoEcKZ2QIkSmmvtZ4ng==", null, false, 3, "4ac5d0f7-e63f-4754-aa31-bb42a973fe0d", "f9e3c2fb-1dec-4f07-ac5a-3b20f22e0692", false, "baran@gmail.com" },
                    { "a3bcfd03-9bc9-4d98-9436-09f1bc813797", 0, "92172383-596a-4891-8f22-ea6a89b74f0c", "ApplicationUser", "venci@gmail.com", false, "Ахмед Матем Ахмед", false, null, "VENCI@GMAIL.COM", "VENCI@GMAIL.COM", "AQAAAAIAAYagAAAAEKdrPzVInGMBGPurgTiGicnnvJl2KoJ1E3fsZUKvYgewiB+GOEi4QYcwcrCRSP7HtA==", null, false, 2, "4ac5d0f7-e63f-4754-aa31-bb42a973fe0d", "e88e86cf-95b7-49ce-a3e2-53e5e7bf267d", false, "venci@gmail.com" },
                    { "bac209f5-c786-4b72-8ca4-9099bba9085b", 0, "52c26068-1573-4508-a020-e885b61302d9", "ApplicationUser", "admin@mail.com", false, "Ахмед Матем Ахмед", false, null, "ADMIN@MAIL.COM", "ADMIN@MAIL.COM", "AQAAAAIAAYagAAAAEPBAQKanmrsT7S+7vb2nGjeKZAK+/CgqackKNvz7/izQ7fcr5VmJ8RvDPVtexGcHbw==", null, false, 0, "4ac5d0f7-e63f-4754-aa31-bb42a973fe0d", "7a7c8b3a-031d-4e6c-a4b4-9049cd0da409", false, "admin@mail.com" },
                    { "e1e5c760-ec84-4abc-b9f3-cc79835a3aac", 0, "55a698fd-991e-4814-96b1-89b13a4dc4ae", "ApplicationUser", "dimitar@gmail.com", false, "Димитър Н. Димитров", false, null, "DIMITAR@GMAIL.COM", "DIMITAR@GMAIL.COM", "AQAAAAIAAYagAAAAEN57CHEhquEL0nbziJ3sNr4FPLYfzRI6gii2H/wow/caX5ZTGfm96RMuILbbFfwXHw==", null, false, 3, "4ac5d0f7-e63f-4754-aa31-bb42a973fe0d", "f8b40278-30bd-4432-8d26-7b7d3d97755a", false, "dimitar@gmail.com" },
                    { "e43e1471-254c-4a12-b755-dc80fb1d2224", 0, "19535697-506e-4fb7-9813-76a7866614d0", "ApplicationUser", "dimana@gmail.com", false, "Димана В. Кънчева", false, null, "DIMANA@GMAIL.COM", "DIMANA@GMAIL.COM", "AQAAAAIAAYagAAAAEMcTDVFe9zkajmCkbzAnkwQRAsKmbZYZidnN5c+S88IZ12mNm9BNADOqzPDc0M0flg==", null, false, 3, "4ac5d0f7-e63f-4754-aa31-bb42a973fe0d", "330a5762-7a14-4570-bdc6-8d422d7e24d9", false, "dimana@gmail.com" },
                    { "ea3aa364-fffc-493f-938e-222f0068a745", 0, "dd43112b-adbd-4703-91b1-d9622347d8d7", "ApplicationUser", "emre@gmail.com", false, "Емре Е. Хюсеин", false, null, "EMRE@GMAIL.COM", "EMRE@GMAIL.COM", "AQAAAAIAAYagAAAAEKcjDcX/YuzYdw1MbEl7l7tFora4JE0HOuPkVFuJhqNX46Sef0xNB6hu4MEgyw4X/Q==", null, false, 3, "4ac5d0f7-e63f-4754-aa31-bb42a973fe0d", "1eaaaa98-0d80-4e3b-9f76-576ac1f95c61", false, "emre@gmail.com" },
                    { "fbb3e516-0ec3-4652-9731-daed5b9a2594", 0, "21eba3a3-550f-4a8e-8666-c6103c39a238", "ApplicationUser", "ivan@gmail.com", false, "Иван Д. Генчев", false, null, "IVAN@GMAIL.COM", "IVAN@GMAIL.COM", "AQAAAAIAAYagAAAAEKOCJ6NaBYppK+GniNc7ho2yTvtO52WU15kd2U8Ir1QEVBtTloDEPp6XtNRDIF0n0Q==", null, false, 3, "4ac5d0f7-e63f-4754-aa31-bb42a973fe0d", "f8abaae6-ce0a-4e69-984b-b20bec42656a", false, "ivan@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "e7557676-0429-43b7-8e91-83caf6b739a2", "bac209f5-c786-4b72-8ca4-9099bba9085b" });
        }
    }
}
