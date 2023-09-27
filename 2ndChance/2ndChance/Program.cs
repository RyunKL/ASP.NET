using _2ndChance.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddRouting(options =>
{
    options.AppendTrailingSlash= true;
    options.LowercaseUrls= true;
});

builder.Services.AddDbContext<ContactContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("ContactContext")));
var app = builder.Build();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}/{slug?}");

app.Run();
