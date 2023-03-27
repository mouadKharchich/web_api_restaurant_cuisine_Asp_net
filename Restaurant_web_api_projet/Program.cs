using Abstructs;
using DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Profiles;
using Services;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IRestaurantService, RestaurantService>();
builder.Services.AddScoped<ICuisineService, CuisineService>();

builder.Services.AddDbContextPool<RestaurantContext>(
    dbContextOptions =>
    {
        dbContextOptions.UseSqlServer(
            builder.Configuration["ConnectionStrings:SqlDbConnection"],
            b => b.MigrationsAssembly("Restaurant_web_api_projet"));
    }
);

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
