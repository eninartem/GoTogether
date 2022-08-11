using MediatR;

namespace Peoples.Application.CQRS.Profiles.Commands.CreateGtProfile;

public class CreateGtProfileCommand : IRequest<Guid>
{
    public Guid AppUserId { get; set; }

    public string NickName { get; set; }

    public Guid LocationId { get; set; }

    public string EMail { get; set; }
}
