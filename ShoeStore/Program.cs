using ShoeStore.BL.Interfaces;
using ShoeStore.BL.Services;
using ShoeStore.DL.Interfaces;
using FluentValidation;
using ShoeStore.HealthCheck;

namespace ShoeStore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services
                .AddSingleton<IShoeService, ShoeRepository>();
            builder.Services
                .AddSingleton<IShoeService, ShoeService>();
            builder.Services
                .AddSingleton<IBrandRepository, BrandRepository>();
            builder.Services
                .AddSingleton<IBrandService, BrandService>();
            builder.Services
                .AddSingleton<IStoreService, StoreService>();

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services
                .AddFluentValidationAutoValidation();
            builder.Services
                .AddValidatorsFromAssemblyContaining(typeof(Program));

            builder.Services.AddHealthChecks()
                .AddCheck<CustomHealthCheck>(nameof(CustomHealthCheck));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapHealthChecks("/healthz");

            app.MapControllers();

            app.Run();
        }
    }
}


