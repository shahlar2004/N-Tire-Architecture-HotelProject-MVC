using HotelProject.Data.Context;
using HotelProject.Data.Extensions;
using HotelProject.Service.Extensions;
using HotelProject.Entity.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;



namespace HotelProject.Web

{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.LoadDataLayerExtension(builder.Configuration);
            builder.Services.LoadServiceLayerExtension();

            //builder.Services.AddDbContext<AppDbContext>(opt =>
            //{
            //    opt.UseSqlServer(builder.Configuration.GetConnectionString("Key"));
            //});
            //builder.Services.AddIdentity<AppUser, IdentityRole>().
            //    AddEntityFrameworkStores<AppDbContext>();



            builder.Services.AddIdentity<AppUser, Role>(opt =>
            {
                opt.Password.RequireNonAlphanumeric = false;
                opt.Password.RequireLowercase = false;
                opt.Password.RequireUppercase = false;
            })
           .AddEntityFrameworkStores<AppDbContext>()
           .AddDefaultTokenProviders();



            builder.Services.ConfigureApplicationCookie(config =>
            {
                config.LoginPath = new PathString("/Admin/Auth/Login");
                config.LogoutPath = new PathString("/Admin/Auth/Logout");
                config.Cookie = new CookieBuilder()
                {
                    Name = "HotelProject",
                    HttpOnly = true,
                    SameSite = SameSiteMode.Strict,
                    SecurePolicy = CookieSecurePolicy.SameAsRequest
                };

                config.SlidingExpiration = true;
                config.ExpireTimeSpan = TimeSpan.FromDays(1);
                config.AccessDeniedPath = new PathString("/Admin/Auth/AccessDenied");

            });




            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            //app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapAreaControllerRoute
                (
                    name: "Admin",
                    areaName: "Admin",
                    pattern: "Admin/{controller=Auth}/{action=Login}/{id?}"
                );

                endpoints.MapDefaultControllerRoute();
            });

            app.Run();
        }
    }
}
