using M2Task.Domain.Model.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace M2Task.Infrastructure;

public class TheOtherContext : DbContext
{
    private readonly static string connectionStringName
        = "ConnectionStringThatShouldntActuallyBePushedToGithubAndShouldntHaveSuchALongNameAgen";

    internal DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

        optionsBuilder.UseSqlServer(config.GetConnectionString(connectionStringName));
    }
}
