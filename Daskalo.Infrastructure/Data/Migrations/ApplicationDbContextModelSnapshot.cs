﻿// <auto-generated />
using System;
using Daskalo.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Daskalo.Infrastructure.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Daskalo.Infrastructure.Data.Models.Group", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)")
                        .HasComment("Unique data model identifier.");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2")
                        .HasComment("Mark the date of created the record on in the table.");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2")
                        .HasComment("Mark the date of deleting the record in the table.");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)")
                        .HasComment("Group description.");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasComment("Group image.");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit")
                        .HasComment("Indicate a record in table as deleted or not.");

                    b.Property<DateTime?>("LastModifiedOn")
                        .HasColumnType("datetime2")
                        .HasComment("Mark the date of last modifing the record in the table.");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasComment("Group name.");

                    b.Property<string>("SchoolId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)")
                        .HasComment("Unique school identifier the group belongng to.");

                    b.Property<string>("ShortName")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasComment("Group short name.");

                    b.Property<string>("TeacherId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)")
                        .HasComment("Group creator unique identifier.");

                    b.HasKey("Id");

                    b.HasIndex("SchoolId");

                    b.HasIndex("TeacherId");

                    b.ToTable("Groups", t =>
                        {
                            t.HasComment("Model of a group in the school.");
                        });
                });

            modelBuilder.Entity("Daskalo.Infrastructure.Data.Models.GroupMember", b =>
                {
                    b.Property<string>("GroupId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("MemberId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("GroupId", "MemberId");

                    b.HasIndex("MemberId");

                    b.ToTable("GroupsAndMembers", (string)null);
                });

            modelBuilder.Entity("Daskalo.Infrastructure.Data.Models.GroupTopic", b =>
                {
                    b.Property<string>("GroupId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("TopicId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("GroupId", "TopicId");

                    b.HasIndex("TopicId");

                    b.ToTable("GroupsAndTopics", (string)null);
                });

            modelBuilder.Entity("Daskalo.Infrastructure.Data.Models.QuizModels.Option", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)")
                        .HasComment("Unique data model identifier.");

                    b.Property<bool>("CorrectAnswer")
                        .HasColumnType("bit")
                        .HasComment("Indicates whether the option is the question correct answer.");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2")
                        .HasComment("Mark the date of created the record on in the table.");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2")
                        .HasComment("Mark the date of deleting the record in the table.");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasComment("Image that could be attached to the option of the question.");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit")
                        .HasComment("Indicate a record in table as deleted or not.");

                    b.Property<DateTime?>("LastModifiedOn")
                        .HasColumnType("datetime2")
                        .HasComment("Mark the date of last modifing the record in the table.");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasComment("Message for those who choose this option.");

                    b.Property<string>("QuestionId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)")
                        .HasComment("Unique identifier of the option.");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasComment("Text represents the  content of the option.");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId");

                    b.ToTable("Options", t =>
                        {
                            t.HasComment("Question option data model.");
                        });
                });

            modelBuilder.Entity("Daskalo.Infrastructure.Data.Models.QuizModels.Question", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)")
                        .HasComment("Unique data model identifier.");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2")
                        .HasComment("Mark the date of created the record on in the table.");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2")
                        .HasComment("Mark the date of deleting the record in the table.");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasComment("Image that could be attached to the text content of the question.");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit")
                        .HasComment("Indicate a record in table as deleted or not.");

                    b.Property<DateTime?>("LastModifiedOn")
                        .HasColumnType("datetime2")
                        .HasComment("Mark the date of last modifing the record in the table.");

                    b.Property<bool>("MultipleAnswers")
                        .HasColumnType("bit")
                        .HasComment("Indicates if the question allows multiple answers or not.");

                    b.Property<int>("OrderNumber")
                        .HasColumnType("int")
                        .HasComment("The number of order in the sequence of questions in the quiz.");

                    b.Property<int>("Points")
                        .HasColumnType("int")
                        .HasComment("The question points.");

                    b.Property<string>("QuizId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)")
                        .HasComment("Unique identifier of the Quiz the question belongs to.");

                    b.Property<bool>("ShuffleOptions")
                        .HasColumnType("bit")
                        .HasComment("Indicates if the options in the question must be shuffled or not.");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasComment("Text representing the content of the question.");

                    b.HasKey("Id");

                    b.HasIndex("QuizId");

                    b.ToTable("Questions", t =>
                        {
                            t.HasComment("Question data model.");
                        });
                });

            modelBuilder.Entity("Daskalo.Infrastructure.Data.Models.QuizModels.Quiz", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)")
                        .HasComment("Unique data model identifier.");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2")
                        .HasComment("Mark the date of created the record on in the table.");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2")
                        .HasComment("Mark the date of deleting the record in the table.");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit")
                        .HasComment("Indicate a record in table as deleted or not.");

                    b.Property<DateTime?>("LastModifiedOn")
                        .HasColumnType("datetime2")
                        .HasComment("Mark the date of last modifing the record in the table.");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasComment("The name of the Quiz");

                    b.HasKey("Id");

                    b.ToTable("Quizzes", t =>
                        {
                            t.HasComment("Quiz data model.");
                        });
                });

            modelBuilder.Entity("Daskalo.Infrastructure.Data.Models.School", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)")
                        .HasComment("Unique data model identifier.");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)")
                        .HasComment("The name of the city where school is located.");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2")
                        .HasComment("Mark the date of created the record on in the table.");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2")
                        .HasComment("Mark the date of deleting the record in the table.");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit")
                        .HasComment("Indicate a record in table as deleted or not.");

                    b.Property<DateTime?>("LastModifiedOn")
                        .HasColumnType("datetime2")
                        .HasComment("Mark the date of last modifing the record in the table.");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasComment("School name.");

                    b.Property<string>("SchoolAdminId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)")
                        .HasComment("Unique identifier of the school administrator.");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(7)
                        .HasColumnType("nvarchar(7)")
                        .HasComment("School type identifier - например: ОУ, ППМГ, ГПЕЧЕ.");

                    b.HasKey("Id");

                    b.HasIndex("SchoolAdminId")
                        .IsUnique();

                    b.ToTable("School");
                });

            modelBuilder.Entity("Daskalo.Infrastructure.Data.Models.Topic", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)")
                        .HasComment("Unique data model identifier.");

                    b.Property<string>("Contents")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasComment("Topic contents items separated each in a new line.");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2")
                        .HasComment("Mark the date of created the record on in the table.");

                    b.Property<string>("CreatorId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)")
                        .HasComment("Unique identifier of the creator of the topic.");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2")
                        .HasComment("Mark the date of deleting the record in the table.");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)")
                        .HasComment("Topic description.");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit")
                        .HasComment("Indicate a record in table as deleted or not.");

                    b.Property<DateTime?>("LastModifiedOn")
                        .HasColumnType("datetime2")
                        .HasComment("Mark the date of last modifing the record in the table.");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasComment("Topic name");

                    b.HasKey("Id");

                    b.HasIndex("CreatorId");

                    b.ToTable("Topics");
                });

            modelBuilder.Entity("Daskalo.Infrastructure.Data.Models.TopicAndResource", b =>
                {
                    b.Property<string>("TopicId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("TopicResurceId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("TopicId", "TopicResurceId");

                    b.HasIndex("TopicResurceId");

                    b.ToTable("TopicsAndResources", (string)null);
                });

            modelBuilder.Entity("Daskalo.Infrastructure.Data.Models.TopicResource", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)")
                        .HasComment("Unique data model identifier.");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2")
                        .HasComment("Mark the date of created the record on in the table.");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2")
                        .HasComment("Mark the date of deleting the record in the table.");

                    b.Property<string>("Icon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasComment("Resource specific icon.");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit")
                        .HasComment("Indicate a record in table as deleted or not.");

                    b.Property<DateTime?>("LastModifiedOn")
                        .HasColumnType("datetime2")
                        .HasComment("Mark the date of last modifing the record in the table.");

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasComment("Link to the resource.");

                    b.Property<string>("OwnerId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)")
                        .HasComment("Unique identifier of the creator of the resource.");

                    b.Property<string>("TextToDisplay")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)")
                        .HasComment("Resource text to display.");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("TopicResources");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(21)
                        .HasColumnType("nvarchar(21)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Daskalo.Infrastructure.Data.Models.ApplicationUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)")
                        .HasComment("User full name.");

                    b.Property<int>("Role")
                        .HasColumnType("int")
                        .HasComment("The role of the user in school - teacher or student");

                    b.Property<string>("SchoolId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)")
                        .HasComment("Unique identifier of school the user wants to participate in.");

                    b.HasIndex("SchoolId");

                    b.HasDiscriminator().HasValue("ApplicationUser");
                });

            modelBuilder.Entity("Daskalo.Infrastructure.Data.Models.Group", b =>
                {
                    b.HasOne("Daskalo.Infrastructure.Data.Models.School", "School")
                        .WithMany()
                        .HasForeignKey("SchoolId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Daskalo.Infrastructure.Data.Models.ApplicationUser", "Teacher")
                        .WithMany()
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("School");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("Daskalo.Infrastructure.Data.Models.GroupMember", b =>
                {
                    b.HasOne("Daskalo.Infrastructure.Data.Models.Group", "Group")
                        .WithMany()
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Daskalo.Infrastructure.Data.Models.ApplicationUser", "Member")
                        .WithMany()
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Group");

                    b.Navigation("Member");
                });

            modelBuilder.Entity("Daskalo.Infrastructure.Data.Models.GroupTopic", b =>
                {
                    b.HasOne("Daskalo.Infrastructure.Data.Models.Group", "Group")
                        .WithMany()
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Daskalo.Infrastructure.Data.Models.Topic", "Topic")
                        .WithMany()
                        .HasForeignKey("TopicId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Group");

                    b.Navigation("Topic");
                });

            modelBuilder.Entity("Daskalo.Infrastructure.Data.Models.QuizModels.Option", b =>
                {
                    b.HasOne("Daskalo.Infrastructure.Data.Models.QuizModels.Question", "Question")
                        .WithMany("Options")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Question");
                });

            modelBuilder.Entity("Daskalo.Infrastructure.Data.Models.QuizModels.Question", b =>
                {
                    b.HasOne("Daskalo.Infrastructure.Data.Models.QuizModels.Quiz", "Quiz")
                        .WithMany("Questions")
                        .HasForeignKey("QuizId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Quiz");
                });

            modelBuilder.Entity("Daskalo.Infrastructure.Data.Models.School", b =>
                {
                    b.HasOne("Daskalo.Infrastructure.Data.Models.ApplicationUser", "SchoolAdmin")
                        .WithOne("School")
                        .HasForeignKey("Daskalo.Infrastructure.Data.Models.School", "SchoolAdminId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SchoolAdmin");
                });

            modelBuilder.Entity("Daskalo.Infrastructure.Data.Models.Topic", b =>
                {
                    b.HasOne("Daskalo.Infrastructure.Data.Models.ApplicationUser", "Creator")
                        .WithMany()
                        .HasForeignKey("CreatorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Creator");
                });

            modelBuilder.Entity("Daskalo.Infrastructure.Data.Models.TopicAndResource", b =>
                {
                    b.HasOne("Daskalo.Infrastructure.Data.Models.Topic", "Topic")
                        .WithMany()
                        .HasForeignKey("TopicId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Daskalo.Infrastructure.Data.Models.TopicResource", "TopicResource")
                        .WithMany()
                        .HasForeignKey("TopicResurceId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Topic");

                    b.Navigation("TopicResource");
                });

            modelBuilder.Entity("Daskalo.Infrastructure.Data.Models.TopicResource", b =>
                {
                    b.HasOne("Daskalo.Infrastructure.Data.Models.ApplicationUser", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Daskalo.Infrastructure.Data.Models.ApplicationUser", b =>
                {
                    b.HasOne("Daskalo.Infrastructure.Data.Models.School", null)
                        .WithMany("Members")
                        .HasForeignKey("SchoolId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("Daskalo.Infrastructure.Data.Models.QuizModels.Question", b =>
                {
                    b.Navigation("Options");
                });

            modelBuilder.Entity("Daskalo.Infrastructure.Data.Models.QuizModels.Quiz", b =>
                {
                    b.Navigation("Questions");
                });

            modelBuilder.Entity("Daskalo.Infrastructure.Data.Models.School", b =>
                {
                    b.Navigation("Members");
                });

            modelBuilder.Entity("Daskalo.Infrastructure.Data.Models.ApplicationUser", b =>
                {
                    b.Navigation("School")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
