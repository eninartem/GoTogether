using Peoples.Application.CQRS.Profiles.Commands.UpdateGtProfile;
using Peoples.Application.CQRS.Profiles.Queries.GetGtProfileDetails;
using Peoples.Domain;

namespace Peoples.Application.Contracts.Repositories;

public interface IGtProfileRepository
{
    Task<IEnumerable<GtProfileDetailsDto>> GetGtProfilesAsync();

    Task<GtProfileDetailsDto> GetGtProfileAsync(Guid guid);

    Task<Guid> CreateGtProfileAsync(GtProfile GtProfile, CancellationToken token);

    Task<GtProfileDetailsDto> UpdateGtProfileAsync(UpdateGtProfileCommand updateGtProfileCommand);

    Task<bool> DeleteGtProfileAsync(Guid id);
}
