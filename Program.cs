var builder = WebApplication.CreateBuilder(args);

// called this method for MapControllerRoute to work properly, this method itself adds a lot of required dependencies hover to find out
builder.Services.AddControllersWithViews();
var app = builder.Build();

// For using static bootstrap files
app.UseStaticFiles();

// Routing is the whole point sooo
app.UseRouting();

// Controller name in this case HomeController then action means method name so index method id? means optional
app.MapControllerRoute(
    name: "defaul",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
