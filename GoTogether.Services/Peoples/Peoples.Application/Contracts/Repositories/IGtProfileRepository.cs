using Peoples.Application.CQRS.Profiles.Queries;

namespace Peoples.Application.Contracts.Repositories;

public interface IGtProfileRepository
{
    Task<IEnumerable<GtProfileDetailsDto>> GetGtProfilesAsync();
    Task<GtProfileDetailsDto> GetGtProfileAsync(Guid guid);
    Task<GtProfileDetailsDto> CreateUpdateGtProfileAsync(GtProfileDetailsDto dto);
    Task<bool> DeleteGtProfileAsync(Guid id);
}
