using Azure.Storage.Blobs;
using Daskalo.Core.Contracts;
using Daskalo.Core.Services;
using Daskalo.Infrastructure.Data;
using Daskalo.Infrastructure.Data.DataRepository;
using Daskalo.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Daskalo.Web.Extensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<ISchoolService, SchoolService>();
            services.AddScoped<ITeacherService, TeacherService>();
            services.AddScoped<IGroupService, GroupService>();
            services.AddScoped<IStudentService, StudentService>();
            services.AddScoped<ITopicService, TopicService>();
            services.AddScoped<ITopicResourceService, TopicResourceService>();
            services.AddScoped<ITopicResourceStorageService, TopicResourceStorageService>();

            return services;
        }

        public static IServiceCollection AddApplicationDbContext(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(connectionString))
                .AddDatabaseDeveloperPageExceptionFilter();

            services.AddSingleton(x => new BlobServiceClient(
                configuration.GetValue<string>("ConnectionStrings:AzureStorageConnectionString")));

            services.AddScoped<IRepository, Repository>();

            return services;
        }

        public static IServiceCollection AddApplicationIdentity(this IServiceCollection services)
        {
            services.AddDefaultIdentity<ApplicationUser>(
                options =>
                {
                    options.SignIn.RequireConfirmedEmail = false;
                    options.Password.RequireDigit = false;
                    options.Password.RequireNonAlphanumeric = false;
                    options.Password.RequireUppercase = false;
                    options.Password.RequireLowercase = false;
                })
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>();

            return services;
        }
    }
}
