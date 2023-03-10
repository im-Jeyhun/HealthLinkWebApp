using AspNetCore.IServiceCollection.AddIUrlHelper;
using HealthLinkWebApp.BackgroundService;

using FluentValidation;
using FluentValidation.AspNetCore;
using HealthLinkWebApp.Infrastructure.Configurations;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;

namespace HealthLinkWebApp.Infrastructure.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void ConfigureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(o =>
                {
                    o.Cookie.Name = "Identity";
                    o.ExpireTimeSpan = TimeSpan.FromMinutes(1);
                    o.LoginPath = "/auth/login";
                    o.AccessDeniedPath = "/admin/auth/login";
                });

            services.AddAutoMapper(typeof(Program));
            services.AddUrlHelper();


            services.AddSignalR();

            services.AddHttpContextAccessor();
            services.AddHostedService<DeleteExpiredUpUsers>();


            services.ConfigureMvc();

            services.ConfigureDatabase(configuration);

            services.ConfigureOptions(configuration);

            services.ConfigureFluentValidatios(configuration);

            services.RegisterCustomServices(configuration);
        }
    }
}
