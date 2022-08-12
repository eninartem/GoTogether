namespace Peoples.Application.CQRS.Profiles.Commands.DeleteGtProfile;

public class DeleteGtProfileCommand : IRequest
{
    public Guid Id { get; set; }
}
