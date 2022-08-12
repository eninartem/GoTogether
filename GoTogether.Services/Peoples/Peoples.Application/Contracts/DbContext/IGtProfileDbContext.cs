namespace Peoples.Application.Contracts.DbContext;

public interface IGtProfileDbContext
{
    DbSet<GtProfile> GtProfiles { get; set; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
