using DataAccessLayer.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// DbContext'i DI konteynerine ekleyin
builder.Services.AddDbContext<DataBaseUserContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddSession();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}

app.UseStaticFiles();
app.UseRouting();
app.UseSession(); 
app.UseAuthorization();

// Area routing for Admin area
app.MapControllerRoute(
    name: "areas",
    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

// Default routing for other areas
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

// Custom route for Admin Login
app.MapControllerRoute(
    name: "adminLogin",
    pattern: "Admin/LogIn/Index",
    defaults: new { area = "Admin", controller = "Admin", action = "Index" });

app.MapControllerRoute(
    name: "adminAdmin",
    pattern: "Admin/Admin/Index",
    defaults: new { area = "Admin", controller = "Admin", action = "Index" });

// Default home route
app.MapGet("/", context =>
{
    context.Response.Redirect("/Admin/LogIn/Index");
    return Task.CompletedTask;
});

// Start the app
app.Run();
