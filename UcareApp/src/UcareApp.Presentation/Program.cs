using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Npgsql.EntityFrameworkCore.PostgreSQL;
using UcareApp.Core.Data;
using UcareApp.Core.Place.Base;
using UcareApp.Infrastructure.Place.Repositories;
using UcareApp.Infrastructure.Place.Services;
using UcareApp.Infrastructure.Assembly;
using System.Reflection;
using UcareApp.Core.Auth.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddTransient<IPlaceRepository, PlaceDapperRepository>();
builder.Services.AddScoped<IPlaceService, PlaceService>();
builder.Services.AddMediatR(configuration => {
    configuration.RegisterServicesFromAssembly(
        typeof(InfrastructureAssembly).Assembly
    );
});

builder.Services.AddControllersWithViews();

// Configure Entity Framework and Identity
builder.Services.AddDbContext<MyIdentityDbContext>(options =>
{
    var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
    options.UseNpgsql(connectionString, npgsqlOptions =>
    {
        npgsqlOptions.EnableRetryOnFailure(5);
    });
});

builder.Services.AddIdentity<ApplicationUser, IdentityRole>(options =>
{
    // Configure Identity options here if needed
})
.AddEntityFrameworkStores<MyIdentityDbContext>()
.AddDefaultTokenProviders(); // Optional: Add token providers if you need them

var app = builder.Build();

// Configure the HTTP request pipeline.
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

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
