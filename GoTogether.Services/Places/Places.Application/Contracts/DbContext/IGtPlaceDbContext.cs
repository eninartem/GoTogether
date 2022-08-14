

namespace Places.Application.Contracts.DbContext;

public interface IGtPlaceDbContext
{
    DbSet<GtPlace> GtPlaces { get; set; }

    DbSet<GtLocation> GtLocations { get; set; }
}
