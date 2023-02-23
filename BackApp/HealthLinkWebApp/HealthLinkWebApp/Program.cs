using HealthLinkWebApp.Infrastructure.Extensions;

namespace HealthLinkWebApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //setup
            var builder = WebApplication.CreateBuilder(args);

            //Register services (Ioc container)

            builder.Services.ConfigureServices(builder.Configuration);

            //setup
            var app = builder.Build();


            //Configuration of middleware
            app.ConfigureMiddlewarePipeline();

            //startup
            app.Run();
        }
    }
}