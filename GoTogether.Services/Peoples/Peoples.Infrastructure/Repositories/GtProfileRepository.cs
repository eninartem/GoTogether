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

    public Task<bool> DeleteGtProfileAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public async Task<GtProfile> GetGtProfileAsync(Guid guid)
    {
        return await _dbContext.GtProfiles.FirstOrDefaultAsync(x => x.Id == guid);
    }

    public Task<IEnumerable<GtProfileDetailsDto>> GetGtProfilesAsync()
    {
        throw new NotImplementedException();
    }

    public async Task UpdateGtProfileAsync(GtProfile profile)
    {
        _dbContext.Entry(profile).State = EntityState.Modified;

        await _dbContext.SaveChangesAsync();
    }
}
