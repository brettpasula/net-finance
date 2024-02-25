using Microsoft.EntityFrameworkCore;

namespace NetCoreWebApi;

public sealed class DatabaseContext : DbContext
{
    public DbSet<Credit> CreditAccounts { get; set; }
    public DbSet<Cash> CashAccounts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlite("Data Source=db.sqlite");
}
