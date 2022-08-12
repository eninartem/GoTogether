namespace Peoples.Application.CQRS.Profiles.Queries.GetGtProfile;

public class GtProfileDto : IMapWith<GtProfile>
{
    public string NickName { get; set; }

    public Guid LocationId { get; set; }

    public string EMail { get; set; }

    public string About { get; set; }

    public string Age { get; set; }

    public string ImageUrl { get; set; }

    public void Mapping(Profile profile) =>
        profile.CreateMap<GtProfile, GtProfileDto>();
}
