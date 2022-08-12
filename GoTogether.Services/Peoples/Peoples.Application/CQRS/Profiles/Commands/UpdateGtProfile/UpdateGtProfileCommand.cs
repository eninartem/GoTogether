namespace Peoples.Application.CQRS.Profiles.Commands.UpdateGtProfile;

public class UpdateGtProfileCommand : IRequest
{
    public Guid Id { get; set; }

    public string NickName { get; set; }

    public Guid LocationId { get; set; }

    public string EMail { get; set; }

    public string About { get; set; }

    public string Age { get; set; }

    public string ImageUrl { get; set; }
}
