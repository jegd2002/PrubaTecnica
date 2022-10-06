using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using pruebaTecnica.Data;
using pruebaTecnica.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var connectionString = builder.Configuration.GetConnectionString("PostgreSQLConnection");
builder.Services.AddDbContext<WebDb>(options =>
    options.UseNpgsql(connectionString));

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

app.MapPost("/productos/", async (productos producto, WebDb db) =>
{

    db.productos.Add(producto);
    await db.SaveChangesAsync();

    return Results.Created($"/productos/{producto.Id}", producto);

});

app.MapGet("/productos/{id:int}", async (int id, WebDb db) =>
{

    return await db.productos.FindAsync(id)
        is productos prd
        ? Results.Ok(prd)
        : Results.NotFound();
});

app.Run();
