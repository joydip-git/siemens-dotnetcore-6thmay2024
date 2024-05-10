using FirstAspNetCoreApp.middlewares;

namespace FirstAspNetCoreApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

            //confugure your middleware depndencies
            IServiceCollection collection = builder.Services;
            
            //1. for RESTful APIs
            collection.AddControllers();

            //2. for controller with views applications
            //collection.AddControllersWithViews();

            //3. for Razor apps
            //collection.AddRazorPages();

            //4. for Mvc Core
            //collection.AddMvcCore();

            //5. for (2+3+4) 
            //collection.AddMvc();

            //create application and activate it
            WebApplication app = builder.Build();


            //app.MapRazorPages();
            //apply the middlewares in request/response pipeline
            app.UseCustomMiddleware();
            //app.MapControllers();
            app.Map("/message", async (context) =>
            {
                await context.Response.WriteAsync("map middleeare response");
            });
            app.Map("/", async (context) =>
            {
                await context.Response.WriteAsync("map middleeare response");
            });
            app.Map("/xyz", async (context) =>
            {
                await context.Response.WriteAsync("map middleeare response");
            });
            app.Use(async (context, next) =>
            {
                await Console.Out.WriteLineAsync("my use middleware");
                await next(context);
            });
            //app.Use()
            //app.Use()

            //terminal middleware
            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("response from run middleware...");
            //});

            app.Run();
        }
    }
}
