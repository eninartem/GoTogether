
namespace Peoples.Application.Contracts.Repositories;

public interface IGtProfileRepository
{
    Task<GtProfile> GetGtProfileAsync(Guid guid, CancellationToken token);

    Task<Guid> CreateGtProfileAsync(GtProfile GtProfile, CancellationToken token);

    Task UpdateGtProfileAsync(GtProfile profile, CancellationToken token);

    Task<bool> DeleteGtProfileAsync(GtProfile id, CancellationToken token);
    Task<IEnumerable<GtProfile>> GetGtProfileListAsync(CancellationToken token);
}
