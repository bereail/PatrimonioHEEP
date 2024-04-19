using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PatrimonioAPI.Models;
using PatrimonioAPI.Services.Implementarions;
using PatrimonioAPI.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Configurar servicios de la aplicación
builder.Services.AddScoped<IArticulosServices, ArticulosServices>();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Configurar el contexto de la base de datos
builder.Services.AddDbContext<InventarioDBContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
);

// Construir la aplicación
var app = builder.Build();

// Configurar el pipeline de solicitud HTTP
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
