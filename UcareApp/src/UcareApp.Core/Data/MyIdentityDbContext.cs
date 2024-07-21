namespace UcareApp.Core.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using UcareApp.Core.Auth.Models;


public class MyIdentityDbContext : IdentityDbContext<ApplicationUser>
{
    public MyIdentityDbContext(DbContextOptions<MyIdentityDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<ApplicationUser>(entity => {
            entity.HasIndex(e => e.Email).IsUnique();
        });
    }
}
