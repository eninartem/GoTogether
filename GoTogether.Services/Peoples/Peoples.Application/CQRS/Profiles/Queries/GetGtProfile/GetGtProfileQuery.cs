namespace Peoples.Application.CQRS.Profiles.Queries.GetGtProfile;

public class GetGtProfileQuery : IRequest<GtProfileDto>
{
    public Guid Id { get; set; }
}
