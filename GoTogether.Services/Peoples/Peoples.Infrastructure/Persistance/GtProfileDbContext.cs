using Microsoft.EntityFrameworkCore;

using Peoples.Application.Contracts.DbContext;
using Peoples.Domain;

namespace Peoples.Infrastructure.Persistance;

public class GtProfileDbContext : DbContext, IGtProfileDbContext
{
    public GtProfileDbContext(DbContextOptions<GtProfileDbContext> options) : base(options) { }

    public DbSet<GtProfile> Profiles { get; set; }

    public override Task<int> SaveChangesAsync(CancellationToken token = new CancellationToken())
    {
        foreach (var entry in ChangeTracker.Entries<BaseGtProfile>())
        {
            switch (entry.State)
            {
                case EntityState.Added:
                    entry.Entity.CreatedDate = DateTime.UtcNow;
                    break;
                case EntityState.Modified:
                    entry.Entity.LastModifiedDate = DateTime.UtcNow;
                    break;
            }
        }

        return base.SaveChangesAsync(token);
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfiguration(new GtProfileEntityConfiguration());
        base.OnModelCreating(builder);
    }
}
