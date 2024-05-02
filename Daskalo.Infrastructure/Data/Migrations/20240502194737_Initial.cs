using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Daskalo.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Quizzes",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "Unique data model identifier."),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "The name of the Quiz"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, comment: "Indicate a record in table as deleted or not."),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Mark the date of deleting the record in the table."),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Mark the date of created the record on in the table."),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Mark the date of last modifing the record in the table.")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quizzes", x => x.Id);
                },
                comment: "Quiz data model.");

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "Unique data model identifier."),
                    QuizId = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "Unique identifier of the Quiz the question belongs to."),
                    OrderNumber = table.Column<int>(type: "int", nullable: false, comment: "The number of order in the sequence of questions in the quiz."),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Text representing the content of the question."),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Image that could be attached to the text content of the question."),
                    MultipleAnswers = table.Column<bool>(type: "bit", nullable: false, comment: "Indicates if the question allows multiple answers or not."),
                    Points = table.Column<int>(type: "int", nullable: false, comment: "The question points."),
                    ShuffleOptions = table.Column<bool>(type: "bit", nullable: false, comment: "Indicates if the options in the question must be shuffled or not."),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, comment: "Indicate a record in table as deleted or not."),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Mark the date of deleting the record in the table."),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Mark the date of created the record on in the table."),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Mark the date of last modifing the record in the table.")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Questions_Quizzes_QuizId",
                        column: x => x.QuizId,
                        principalTable: "Quizzes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Question data model.");

            migrationBuilder.CreateTable(
                name: "Options",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "Unique data model identifier."),
                    QuestionId = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "Unique identifier of the option."),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Text represents the  content of the option."),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Image that could be attached to the option of the question."),
                    CorrectAnswer = table.Column<bool>(type: "bit", nullable: false, comment: "Indicates whether the option is the question correct answer."),
                    Message = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false, comment: "Message for those who choose this option."),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, comment: "Indicate a record in table as deleted or not."),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Mark the date of deleting the record in the table."),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Mark the date of created the record on in the table."),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Mark the date of last modifing the record in the table.")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Options", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Options_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Question option data model.");

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(21)", maxLength: 21, nullable: false),
                    SchoolId = table.Column<string>(type: "nvarchar(450)", nullable: true, comment: "Unique identifier of school the user wants to participate in."),
                    FullName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true, comment: "User full name."),
                    Role = table.Column<int>(type: "int", nullable: true, comment: "The role of the user in school - teacher or student"),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "School",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "Unique data model identifier."),
                    SchoolAdminId = table.Column<string>(type: "nvarchar(450)", nullable: true, comment: "Unique identifier of the school administrator."),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false, comment: "School name."),
                    Type = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: false, comment: "School type identifier - например: ОУ, ППМГ, ГПЕЧЕ."),
                    City = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false, comment: "The name of the city where school is located."),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, comment: "Indicate a record in table as deleted or not."),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Mark the date of deleting the record in the table."),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Mark the date of created the record on in the table."),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Mark the date of last modifing the record in the table.")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_School", x => x.Id);
                    table.ForeignKey(
                        name: "FK_School_AspNetUsers_SchoolAdminId",
                        column: x => x.SchoolAdminId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TopicResources",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "Unique data model identifier."),
                    OwnerId = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "Unique identifier of the creator of the resource."),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Link to the resource."),
                    TextToDisplay = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false, comment: "Resource text to display."),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Resource specific icon."),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, comment: "Indicate a record in table as deleted or not."),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Mark the date of deleting the record in the table."),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Mark the date of created the record on in the table."),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Mark the date of last modifing the record in the table.")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TopicResources", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TopicResources_AspNetUsers_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Topics",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "Unique data model identifier."),
                    CreatorId = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "Unique identifier of the creator of the topic."),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "Topic name"),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, comment: "Topic description."),
                    Contents = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Topic contents items separated each in a new line."),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, comment: "Indicate a record in table as deleted or not."),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Mark the date of deleting the record in the table."),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Mark the date of created the record on in the table."),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Mark the date of last modifing the record in the table.")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Topics", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Topics_AspNetUsers_CreatorId",
                        column: x => x.CreatorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "Unique data model identifier."),
                    SchoolId = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "Unique school identifier the group belongng to."),
                    TeacherId = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "Group creator unique identifier."),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "Group name."),
                    ShortName = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false, comment: "Group short name."),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, comment: "Group description."),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Group image."),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, comment: "Indicate a record in table as deleted or not."),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Mark the date of deleting the record in the table."),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Mark the date of created the record on in the table."),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Mark the date of last modifing the record in the table.")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Groups_AspNetUsers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Groups_School_SchoolId",
                        column: x => x.SchoolId,
                        principalTable: "School",
                        principalColumn: "Id");
                },
                comment: "Model of a group in the school.");

            migrationBuilder.CreateTable(
                name: "TopicsAndResources",
                columns: table => new
                {
                    TopicId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TopicResurceId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TopicsAndResources", x => new { x.TopicId, x.TopicResurceId });
                    table.ForeignKey(
                        name: "FK_TopicsAndResources_TopicResources_TopicResurceId",
                        column: x => x.TopicResurceId,
                        principalTable: "TopicResources",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TopicsAndResources_Topics_TopicId",
                        column: x => x.TopicId,
                        principalTable: "Topics",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "GroupsAndMembers",
                columns: table => new
                {
                    GroupId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MemberId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupsAndMembers", x => new { x.GroupId, x.MemberId });
                    table.ForeignKey(
                        name: "FK_GroupsAndMembers_AspNetUsers_MemberId",
                        column: x => x.MemberId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GroupsAndMembers_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "GroupsAndTopics",
                columns: table => new
                {
                    GroupId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TopicId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupsAndTopics", x => new { x.GroupId, x.TopicId });
                    table.ForeignKey(
                        name: "FK_GroupsAndTopics_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GroupsAndTopics_Topics_TopicId",
                        column: x => x.TopicId,
                        principalTable: "Topics",
                        principalColumn: "Id");
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_SchoolId",
                table: "AspNetUsers",
                column: "SchoolId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Groups_SchoolId",
                table: "Groups",
                column: "SchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_Groups_TeacherId",
                table: "Groups",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupsAndMembers_MemberId",
                table: "GroupsAndMembers",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupsAndTopics_TopicId",
                table: "GroupsAndTopics",
                column: "TopicId");

            migrationBuilder.CreateIndex(
                name: "IX_Options_QuestionId",
                table: "Options",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_QuizId",
                table: "Questions",
                column: "QuizId");

            migrationBuilder.CreateIndex(
                name: "IX_School_SchoolAdminId",
                table: "School",
                column: "SchoolAdminId",
                unique: true,
                filter: "[SchoolAdminId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_TopicResources_OwnerId",
                table: "TopicResources",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Topics_CreatorId",
                table: "Topics",
                column: "CreatorId");

            migrationBuilder.CreateIndex(
                name: "IX_TopicsAndResources_TopicResurceId",
                table: "TopicsAndResources",
                column: "TopicResurceId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_School_SchoolId",
                table: "AspNetUsers",
                column: "SchoolId",
                principalTable: "School",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_School_AspNetUsers_SchoolAdminId",
                table: "School");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "GroupsAndMembers");

            migrationBuilder.DropTable(
                name: "GroupsAndTopics");

            migrationBuilder.DropTable(
                name: "Options");

            migrationBuilder.DropTable(
                name: "TopicsAndResources");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "TopicResources");

            migrationBuilder.DropTable(
                name: "Topics");

            migrationBuilder.DropTable(
                name: "Quizzes");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "School");
        }
    }
}
