using M1Task.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace M1Task.Infrastructure;

public class BillingEntryContext : DbContext
{
    private readonly static string connectionStringName
        = "ConnectionStringThatShouldntActuallyBePushedToGithubAndShouldntHaveSuchALongNameAgen";
    internal DbSet<BillingEntry> Stalkers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

        optionsBuilder.UseSqlServer(config.GetConnectionString(connectionStringName));
    }
}
