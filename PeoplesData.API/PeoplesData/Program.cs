using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PeoplesData.Contexts;
using PeoplesData.Interfaces;
using PeoplesData.Repositories;
using PeoplesData.Services;


var builder = WebApplication.CreateBuilder(args);
ConfigurationManager configuration = builder.Configuration;
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddMvc();
builder.Services.AddDbContext<DefaultContext>(options =>
    options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IPeoplesdetailsRepository, PeoplesdetailsRepository>();

builder.Services.AddScoped<IPeoplesdetailsService, PeoplesdetailsService>();

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
