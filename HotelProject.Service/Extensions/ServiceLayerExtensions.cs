using FluentValidation.AspNetCore;
using HotelProject.Service.Services.Abstraction;
using HotelProject.Service.Services.Concrete;
using HotelProject.Service.Validation;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Service.Extensions
{
    public static class ServiceLayerExtensions
    {
        public static IServiceCollection LoadServiceLayerExtension(this IServiceCollection services)
        {
            var assembly = Assembly.GetExecutingAssembly();
            services.AddScoped<ICountryService,CountryService>();   
            services.AddScoped<ICategoriesService,CategoriyService>();
           // services.AddScoped<IRoomsService,RoomsService>();
            services.AddAutoMapper(assembly);
            services.AddControllersWithViews().AddFluentValidation(opt =>
            {
                opt.RegisterValidatorsFromAssemblyContaining<CountryValidation>();
                opt.DisableDataAnnotationsValidation = true;
                opt.ValidatorOptions.LanguageManager.Culture = new CultureInfo("az");
            });
            return services;
            
        }
    }
}
