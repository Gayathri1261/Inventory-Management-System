using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Inventory_Management_System.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<Inventory_Management_SystemContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Inventory_Management_SystemContext") ?? throw new InvalidOperationException("Connection string 'Inventory_Management_SystemContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
