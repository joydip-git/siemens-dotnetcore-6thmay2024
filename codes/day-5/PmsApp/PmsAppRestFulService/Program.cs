using BusinessLogic;
using DataAccessLogic;
using DataSource;
using Entities;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
IServiceCollection services = builder.Services;
services.AddSingleton<IDatabase<Product>,Database>();
services.AddSingleton<IReposiroty<Product,int>,ProductRepository>();
services.AddSingleton<IServiceContract<Product,int>,ProductService>();
services.AddControllers();
services.AddEndpointsApiExplorer();
services.AddSwaggerGen();

WebApplication app = builder.Build();

// Configure the HTTP request pipeline with middlewares
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
