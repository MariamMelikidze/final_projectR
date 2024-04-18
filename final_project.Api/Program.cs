using System.Globalization;
using Final_Project.Data;
using Microsoft.AspNetCore.Localization;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


    // Add DbContext to the DI container

    builder.Services.AddDbContext<FinalDbContext>(options =>
    {
        options.UseSqlServer("Server=RED-SUNS-PC;Database=Final_Work;Integrated Security=True;TrustServerCertificate=True;");
    });

    // Other service configurations...

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
