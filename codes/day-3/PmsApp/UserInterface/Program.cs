using BusinessLogic;
using DataAccessLogic;
using DataSource;
using Entities;
using Microsoft.Extensions.DependencyInjection;
using PmsAppExceptions;

//service => repo => database
try
{
    IServiceCollection container = new ServiceCollection();
    IServiceProvider provider =
        container
        .AddSingleton<IDatabase<Product>, Database>()
        .AddSingleton<IReposiroty<Product, int>, ProductRepository>()
        .AddSingleton<IServiceContract<Product, int>, ProductService>()
        .BuildServiceProvider();

    IServiceContract<Product, int> service = (IServiceContract<Product, int>)provider.GetRequiredService(typeof(IServiceContract<Product, int>));

    var records = service.FetchAll();
    foreach (var item in records)
    {
        Console.WriteLine(item);
    }
}
catch (ServiceException ex)
{
    Console.WriteLine("in catch with SE");
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.StackTrace);
    Console.WriteLine(ex.Source);
    Console.WriteLine(ex.TargetSite);
    Console.WriteLine(ex.InnerException);
    Console.WriteLine(ex.InnerException?.InnerException?.Message);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.StackTrace);
    Console.WriteLine(ex.Source);
    Console.WriteLine(ex.TargetSite);
}