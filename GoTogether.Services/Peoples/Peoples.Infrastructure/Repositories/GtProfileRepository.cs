using Peoples.Application.Contracts.Repositories;
using Peoples.Application.CQRS.Profiles.Queries;

namespace Peoples.Infrastructure.Repositories;

public class GtProfileRepository : IGtProfileRepository
{
    public Task<GtProfileDetailsDto> CreateUpdateGtProfileAsync(GtProfileDetailsDto dto)
    {
        throw new NotImplementedException();
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
}
