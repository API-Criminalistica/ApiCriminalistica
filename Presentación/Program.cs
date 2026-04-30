using Aplicacion.Interfaces;
using Aplicacion.Servicios;

using Dominio.Interfaces;

using Infraestructura.Data;
using Infraestructura.Repositorios;

using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection")
    )
);


builder.Services.AddScoped<IDelitoRepositorio, DelitoRepositorio>();
builder.Services.AddScoped<IPersonaRepositorio, PersonaRepositorio>();
builder.Services.AddScoped<IUbicacionRepositorio, UbicacionRepositorio>();
builder.Services.AddScoped<ITipoDelitoRepositorio, TipoDelitoRepositorio>();


builder.Services.AddScoped<IDelitoServicio, DelitoServicio>();
builder.Services.AddScoped<IPersonaServicio, PersonaServicio>();
builder.Services.AddScoped<IUbicacionServicio, UbicacionServicio>();
builder.Services.AddScoped<ITipoDelitoServicio, TipoDelitoServicio>();

builder.Services.AddControllersWithViews();
builder.Services.AddControllers();


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddCors(options =>
{
    options.AddPolicy("Frontend", policy =>
    {
        policy
            .AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader();
    });
});


var app = builder.Build();


if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");

    app.UseHsts();
}


// Swagger
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();

    app.UseSwaggerUI();
}


app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();


// Frontend
app.UseCors("Frontend");


app.UseAuthorization();


// API Controllers
app.MapControllers();


// MVC
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");



app.Run();