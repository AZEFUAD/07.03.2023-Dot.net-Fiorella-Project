using Fiorella.DAL;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDbContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("Default")));

var app = builder.Build();
app.MapControllerRoute(
     name: "areas",
     pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
);

app.MapDefaultControllerRoute();

//12ci setir beraberdir 14-18-ci setir
//app.MapControllerRoute(
//    name:"default",
//    pattern:"{controller=home}/{action=index}/{id?}"
//);

app.UseStaticFiles();
app.Run(); 
