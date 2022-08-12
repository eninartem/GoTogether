namespace Peoples.Application.Contracts.Repositories;

public interface IGtProfileRepository
{
    Task<IEnumerable<GtProfileDetailsDto>> GetGtProfilesAsync();

    Task<GtProfile> GetGtProfileAsync(Guid guid);

    Task<Guid> CreateGtProfileAsync(GtProfile GtProfile, CancellationToken token);

    Task UpdateGtProfileAsync(GtProfile profile);

    Task<bool> DeleteGtProfileAsync(Guid id);
}
