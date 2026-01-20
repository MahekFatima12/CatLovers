////var builder = WebApplication.CreateBuilder(args);

////// Add services to the container.
////builder.Services.AddRazorPages();
////builder.Services.AddControllersWithViews();

////var app = builder.Build();

////// Configure the HTTP request pipeline.
////if (!app.Environment.IsDevelopment())
////{
////    app.UseExceptionHandler("/Error");
////    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
////    app.UseHsts();
////}

////app.UseHttpsRedirection();
////app.UseStaticFiles();

////app.UseRouting();

////app.UseAuthorization();
////app.MapControllerRoute(
////    name: "default",
////    pattern: "{controller=Home}/{action=Index}/{id?}");

////app.MapRazorPages();

////app.Run();

//using CatLoversWeb.Data;
//using Microsoft.AspNetCore.Identity;
//using Microsoft.EntityFrameworkCore;

//var builder = WebApplication.CreateBuilder(args);

//// DbContext
//builder.Services.AddDbContext<ApplicationDbContext>(options =>
//    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

//// Identity
//builder.Services.AddIdentity<IdentityUser, IdentityRole>()
//    .AddEntityFrameworkStores<ApplicationDbContext>()
//    .AddDefaultTokenProviders();

//// MVC
//builder.Services.AddControllersWithViews();

//var app = builder.Build();

//// Middleware
//app.UseStaticFiles();
//app.UseRouting();

//app.UseAuthentication();
//app.UseAuthorization();

//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Home}/{action=Index}/{id?}");

//app.Run();


using CatLoversWeb.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add DbContext
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Add Identity
builder.Services.AddIdentity<IdentityUser, IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddDefaultTokenProviders();

// Add MVC
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Middleware
app.UseStaticFiles();
app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
