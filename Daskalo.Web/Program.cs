using Daskalo.Web.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace Daskalo.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddApplicationDbContext(builder.Configuration);

            builder.Services.AddApplicationIdentity();

            builder.Services.AddControllersWithViews(options =>
                options.Filters.Add<AutoValidateAntiforgeryTokenAttribute>());

            builder.Services.AddApplicationServices();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapAreaControllerRoute(
                  name: "Admin",
                  areaName: "Admin",
                  pattern: "admin/{controller=Home}/{action=Index}/{id?}"
                );

            app.MapDefaultControllerRoute();

            app.MapRazorPages();

            app.Run();
        }
    }
}
