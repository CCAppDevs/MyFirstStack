using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MyFirstStack.Data;
using MyFirstStack.Infrastructure;
using static System.Net.WebRequestMethods;

namespace MyFirstStack
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<MyFirstStackDb>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("MyFirstStackDb") ?? throw new InvalidOperationException("Connection string 'MyFirstStackDb' not found.")));

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            
            builder.Services.AddHttpClient<DogFactService>((serviceProvider, client) =>
            {
                client.BaseAddress = new Uri("http://dog-api.kinduff.com");
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            //app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
