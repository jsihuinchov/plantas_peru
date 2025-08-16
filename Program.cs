using Microsoft.EntityFrameworkCore;
using plantas_peru.Models;

var builder = WebApplication.CreateBuilder(args);

// Agregamos el contexto con la conexión
builder.Services.AddDbContext<PlantasContext>(options =>
    options.UseMySql(
        builder.Configuration.GetConnectionString("PlantasDb"),
        new MySqlServerVersion(new Version(8.0.0) 
    )
);

builder.Services.AddControllersWithViews();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// 🔹 Cambiamos para que arranque en PlantasController/Index
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Plantas}/{action=Index}/{id?}");

app.Run();
