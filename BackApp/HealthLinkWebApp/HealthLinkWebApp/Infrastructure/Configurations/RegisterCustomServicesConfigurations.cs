
using Microsoft.EntityFrameworkCore;

namespace HealthLinkWebApp.Infrastructure.Configurations
{
    public static class RegisterCustomServicesConfigurations
    {
        public static void RegisterCustomServices(this IServiceCollection services, IConfiguration configuration)
        {
            //services.AddScoped<IEmailService, SMTPService>();
            //services.AddScoped<IUserService, UserService>();
            //services.AddScoped<IBasketService, BasketService>();
            //services.AddSingleton<IFileService, FileService>();
            //services.AddScoped<IOrderService, OrderService>();
            //services.AddScoped<IProductService, ProductService>();
            //services.AddScoped<INotificationService, NotificationService>();
            //services.AddScoped<IUserActivationService, UserActivationService>();
        }
    }
}
