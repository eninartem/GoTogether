using Microsoft.EntityFrameworkCore;

using Places.Application.Contracts.DbContext;
using Places.Domain;

namespace Places.Infrastructure.Persistance;

public class GtPlaceDbContext : DbContext, IGtPlaceDbContext
{
    public GtPlaceDbContext(DbContextOptions<GtPlaceDbContext> options) : base(options) { }

    public DbSet<GtPlace> GtPlaces { get; set; }
    public DbSet<GtLocation> GtLocations { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfiguration(new GtLocationEntityConfiguration());
        builder.ApplyConfiguration(new GtPlaceEntityConfiguration());

        base.OnModelCreating(builder);
    }
}
