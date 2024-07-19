using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Npgsql.EntityFrameworkCore.PostgreSQL;
using UcareApp.Core.Data;
using UcareApp.Core.Place.Base;
using UcareApp.Core.Place.Repositories;
using UcareApp.Core.Place.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddTransient<IPlaceRepository, PlaceDapperRepository>();
builder.Services.AddScoped<IPlaceService, PlaceService>();

builder.Services.AddControllersWithViews();


builder.Services.AddDbContext<MyIdentityDbContext>(options =>
{
    var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
    options.UseNpgsql(connectionString, npgsqlOptions =>
    {
        npgsqlOptions.EnableRetryOnFailure(5);
    });
});


builder.Services.AddIdentity<IdentityUser, IdentityRole>(options =>
{

})
.AddEntityFrameworkStores<MyIdentityDbContext>();

var app = builder.Build();


if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();
builder.Logging.AddConsole();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
