using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Npgsql.EntityFrameworkCore.PostgreSQL;
using UcareApp.Core.Data;

public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<MyIdentityDbContext>
{
    public MyIdentityDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<MyIdentityDbContext>();
        var connectionString = "Host=ucarepostgresqlsrv.postgres.database.azure.com;Database=postgres;Username=ucare_admin;Password=Step_password;Port=5432;SslMode=Require;";
        optionsBuilder.UseNpgsql(connectionString);

        return new MyIdentityDbContext(optionsBuilder.Options);
    }
}
