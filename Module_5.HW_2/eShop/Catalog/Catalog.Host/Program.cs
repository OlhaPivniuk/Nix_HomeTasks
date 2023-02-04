using Catalog.Host.Services;
using Catalog.Host.Services.Abstractions;

namespace Catalog.Host;

public class Program
{
    public static void Main(string[] args)
    {
        CreateHostBuilder(args);
    }

    private static void CreateHostBuilder(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddControllers();
        // Learn more about configuring
        // Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddTransient<IProductService, ProductService>();
        builder.Services.AddSwaggerGen();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}

