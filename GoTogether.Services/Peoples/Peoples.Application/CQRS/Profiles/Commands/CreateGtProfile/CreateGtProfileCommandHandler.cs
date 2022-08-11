using MediatR;

using Peoples.Application.Contracts.Repositories;
using Peoples.Domain;

namespace Peoples.Application.CQRS.Profiles.Commands.CreateGtProfile;

public class CreateGtProfileCommandHandler : IRequestHandler<CreateGtProfileCommand, Guid>
{
    private readonly IGtProfileRepository _gtProfileRepository;

    public CreateGtProfileCommandHandler(IGtProfileRepository gtProfileRepository) =>
        _gtProfileRepository = gtProfileRepository;

    public async Task<Guid> Handle(CreateGtProfileCommand request, CancellationToken cancellationToken)
    {
        var p = new GtProfile
        {
            Id = Guid.NewGuid(),
            AppUserId = request.AppUserId,
            NickName = request.NickName,
            LocationId = request.LocationId,
            EMail = request.EMail
        };

        await _gtProfileRepository.CreateGtProfileAsync(p, cancellationToken);

        return p.Id;
    }
}
