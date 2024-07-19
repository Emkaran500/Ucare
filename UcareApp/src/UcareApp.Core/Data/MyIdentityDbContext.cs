namespace UcareApp.Core.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

public class MyIdentityDbContext : IdentityDbContext<IdentityUser, IdentityRole, string>
{
    public MyIdentityDbContext(DbContextOptions<MyIdentityDbContext> options) : base(options) { }
}
