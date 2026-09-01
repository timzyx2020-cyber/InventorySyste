using InventoryMVC.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add MVC (controllers + views) support
builder.Services.AddControllersWithViews();

// Add EF Core with an in-memory database (no SQL Server install needed for today)
builder.Services.AddDbContext<InventoryContext>(options =>
    options.UseInMemoryDatabase("InventoryDb"));

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

// Default route goes straight to the product list for the demo
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Products}/{action=Index}/{id?}");

app.Run();
