using Microsoft.Extensions.Logging;

namespace FirstAspNetCoreApp.middlewares
{
    public class CustomRequestMiddleware
    {
        private readonly RequestDelegate _requestDelegate;
        //private readonly ILogger _logger;
        //public CustomRequestMiddleware(RequestDelegate requestDelegate, ILogger<T> logger)
        public CustomRequestMiddleware(RequestDelegate requestDelegate)
        {
            _requestDelegate = requestDelegate;
            Console.WriteLine("middleware object created...");
        }

        public async Task InvokeAsync(HttpContext context)
        {
            Console.WriteLine("middleware logic invoked...");
            var routeData = context.Request.RouteValues;
            string? controllerName = null;
            string? routeValue = null;
            if (routeData != null)
            {
                controllerName = routeData["controller"]?.ToString() ?? "na";
                routeValue = routeData["data"]?.ToString() ?? "value na";
            }
            //code
            Console.WriteLine($"{controllerName},{routeValue}");
            //Console.WriteLine(routeData["controller"] ?? "na");
            //Console.WriteLine(routeData["action"] ?? "na");

            await _requestDelegate(context);
        }
    }
    public static class CustomRequestMiddlewareExtension
    {
        public static IApplicationBuilder UseCustomMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<CustomRequestMiddleware>();
        }
        //public static IApplicationBuilder UseCustomMiddleware2(this IApplicationBuilder builder)
        //{
        //    return builder.UseMiddleware<CustomRequestMiddleware2>();
        //}
    }
}
