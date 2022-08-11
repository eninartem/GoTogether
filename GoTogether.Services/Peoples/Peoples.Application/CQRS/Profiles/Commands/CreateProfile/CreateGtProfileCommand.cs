using MediatR;

namespace Peoples.Application.CQRS.Profiles.Commands.CreateProfile;

public class CreateGtProfileCommand : IRequest<Guid>
{
    public Guid Id { get; set; }

    public Guid AppUserId { get; set; }

    public string NickName { get; set; }

    public Guid LocationId { get; set; }

    public string EMail { get; set; }
}
