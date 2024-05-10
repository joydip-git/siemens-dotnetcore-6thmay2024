namespace FirstAspNetCoreApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
            IServiceCollection collection = builder.Services;
            collection.AddControllers();

            WebApplication app = builder.Build();

            app.MapControllers();
           
            app.Run();
        }
    }
}
