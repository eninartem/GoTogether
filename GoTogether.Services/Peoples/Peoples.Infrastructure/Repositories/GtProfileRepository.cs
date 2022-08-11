using Peoples.Application.Contracts.Repositories;
using Peoples.Application.CQRS.Profiles.Commands.UpdateGtProfile;
using Peoples.Application.CQRS.Profiles.Queries.GetGtProfileDetails;
using Peoples.Domain;
using Peoples.Infrastructure.Persistance;

namespace Peoples.Infrastructure.Repositories;

public class GtProfileRepository : IGtProfileRepository
{
    protected readonly GtProfileDbContext _dbContext;

    public GtProfileRepository(GtProfileDbContext dbContext) =>
        _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));

    public async Task<Guid> CreateGtProfileAsync(GtProfile GtProfile, CancellationToken token)
    {
        _dbContext.Add(GtProfile);

        await _dbContext.SaveChangesAsync(token);

        return GtProfile.Id;
    }

    public Task<bool> DeleteGtProfileAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<GtProfileDetailsDto> GetGtProfileAsync(Guid guid)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<GtProfileDetailsDto>> GetGtProfilesAsync()
    {
        throw new NotImplementedException();
    }

    public Task<GtProfileDetailsDto> UpdateGtProfileAsync(UpdateGtProfileCommand updateGtProfileCommand)
    {
        throw new NotImplementedException();
    }
}
