using MediatR;

using Peoples.Domain;

namespace Peoples.Application.CQRS.Profiles.Commands.CreateProfile;

public class CreateGtProfileCommandHandler : IRequestHandler<CreateGtProfileCommand, Guid>
{
    public async Task<Guid> Handle(CreateGtProfileCommand request, CancellationToken cancellationToken)
    {
        var p = new GtProfile
        {
            Id = request.Id,
            AppUserId = request.AppUserId,
            NickName = request.NickName,
            LocationId = request.LocationId,
            EMail = request.EMail
        };

        return p.Id;
    }
}
