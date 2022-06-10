using Microsoft.EntityFrameworkCore;
using projectApi.Database;
using projectApi.Model;
using Microsoft.AspNetCore.Identity;
using projectApi.Service;
using projectApi.Repository;
using projectApi.AutoMapper;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionstring = builder.Configuration.GetConnectionString("MatchDBConnectionString");
builder.Services.AddDbContextFactory<MatchContext>(options =>
    //options.UseSqlServer("Server=localhost;Database=car-trading_DB;Trusted_Connection=False;User Id=sa;password=!VavUci01;MultipleActiveResultSets=true;"));
    //options.UseSqlServer("Server=192.168.1.19;Database=car-trading_DB;Trusted_Connection=False;User Id=sa;password=_WestMount01;MultipleActiveResultSets=true;"));
    options.UseSqlServer(connectionstring),
    ServiceLifetime.Scoped);

builder.Services.AddControllers();
builder.Services.AddTransient<IMatchService, MatchService>();
builder.Services.AddTransient<IMatchRepository, MatchRepository>();
builder.Services.AddAutoMapper(typeof(MatchProfile));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
        c.RoutePrefix = "";
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
