using M1Task.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace M1Task.Infrastructure;

public class AllegroContext : DbContext
{
    private static AllegroContext? _context;
    internal static AllegroContext Context => _context ??= new AllegroContext();

    private readonly static string connectionStringName
        = "ConnectionStringThatShouldntActuallyBePushedToGithubAndShouldntHaveSuchALongNameAgen";
    internal DbSet<Billing> Billings { get; set; }
    internal DbSet<OrderTable> OrderTable { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

        optionsBuilder.UseSqlServer(config.GetConnectionString(connectionStringName));
    }
}
