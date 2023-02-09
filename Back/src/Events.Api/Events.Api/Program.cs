using Events.Api.Data;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var connectionStringMySql = builder.Configuration.GetConnectionString("EventsContext");
builder.Services.AddDbContext<EventsContext>(options => options.UseMySql(builder.Configuration.GetConnectionString("EventsContext"),
    MySqlServerVersion.LatestSupportedServerVersion, builder => builder.MigrationsAssembly("Events.Api")));

builder.Services.AddControllers();
builder.Services.AddCors();
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

app.UseCors(x => x.AllowAnyHeader()
                  .AllowAnyMethod()
                  .AllowAnyOrigin());

app.MapControllers();

app.Run();
