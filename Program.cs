using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);



// Add services to the container.

builder.Services.AddControllersWithViews();

var app = builder.Build();

/*
if (builder.Environment.IsDevelopment())
{
    builder.Services.AddDbContext<MvcReactEmpleadoContext>(options =>
        options.UseSqlite(builder.Configuration.GetConnectionString("MvcReactEmpleadoContext")));
}
else
{
    builder.Services.AddDbContext<MvcReactEmpleadoContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("ProductionMvcReactEmpleadoContext")));
}*/


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}




app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html");

app.Run();
