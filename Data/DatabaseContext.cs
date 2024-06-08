using Microsoft.EntityFrameworkCore;
using Sitchensis.Data.Object;

namespace Sitchensis.Data;

public sealed class DatabaseContext : DbContext
{
    public DbSet<Credit> CreditAccounts { get; set; }
    public DbSet<Cash> CashAccounts { get; set; }
    public DbSet<Unit> Units { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlite("Data Source=Sitchensis.sqlite");
}
