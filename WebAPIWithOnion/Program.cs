using Microsoft.EntityFrameworkCore;
using WebApiWithOnion.models.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
string myConnection = builder.Configuration.GetConnectionString("defaultdConnection");
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<SchoolDbContext>(options =>
{
options.UseSqlServer(myConnection);

}, ServiceLifetime.Transient
);


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
