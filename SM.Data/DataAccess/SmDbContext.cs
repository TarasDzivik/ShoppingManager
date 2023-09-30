using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace SM.Data.DataAccess;
public class SmDbContext : DbContext
{
    public SmDbContext(DbContextOptions<SmDbContext> options) : base(options) { }

    #region DbSets
    //public DbSet<SeriLoggerEventModel> SeriLoggerEvents { get; set; }
    //public DbSet<Properties> LogProperties { get; set; }

    #endregion

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
