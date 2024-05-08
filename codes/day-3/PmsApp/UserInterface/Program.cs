//Service => repo => database
using BusinessLogic;
using DataAccessLogic;
using DataSource;
using Entities;
using Microsoft.Extensions.DependencyInjection;

IServiceCollection container = new ServiceCollection();
container
    .AddSingleton<IDatabase, Database>()
    .AddSingleton<IReposiroty<Product, int>, ProductRepository>()
    .AddSingleton<IServiceContract<Product, int>, ProductService>();



    


    
    
