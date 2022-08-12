namespace Peoples.Infrastructure.Repositories;

public class GtProfileRepository : IGtProfileRepository
{
    protected readonly GtProfileDbContext _dbContext;

    public GtProfileRepository(GtProfileDbContext dbContext) =>
        _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));

    public async Task<Guid> CreateGtProfileAsync(GtProfile GtProfile, CancellationToken token)
    {
        await _dbContext.Set<GtProfile>().AddAsync(GtProfile, token);

        await _dbContext.SaveChangesAsync(token);

        return GtProfile.Id;
    }

    public async Task<bool> DeleteGtProfileAsync(GtProfile profile, CancellationToken token)
    {
        _dbContext.Set<GtProfile>().Remove(profile);

        return await _dbContext.SaveChangesAsync(token) > 0;
    }

    public async Task<GtProfile> GetGtProfileAsync(Guid guid, CancellationToken token)
    {
        return await _dbContext.Set<GtProfile>().FindAsync(new object[] { guid }, token);
    }

    public async Task<IEnumerable<GtProfile>> GetGtProfileListAsync(CancellationToken token)
    {
        var profileList = await _dbContext.Set<GtProfile>().ToListAsync(token);

        return profileList;
    }

    public async Task UpdateGtProfileAsync(GtProfile profile, CancellationToken token)
    {
        _dbContext.Entry(profile).State = EntityState.Modified;

        await _dbContext.SaveChangesAsync(token);
    }
}
