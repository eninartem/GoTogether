using AutoMapper;

using Peoples.Application.Contracts.Mapping;
using Peoples.Domain;

namespace Peoples.Application.CQRS.Profiles.Queries;

public class GtProfileDetailsDto : IMapWith<GtProfile>
{
    public Guid Id { get; set; }

    public string NickName { get; set; }

    public Guid LocationId { get; set; }

    public string EMail { get; set; }

    public string About { get; set; }

    public string Age { get; set; }

    public string ImageUrl { get; set; }

    public void Mapping(Profile profile) =>
        profile.CreateMap<GtProfile, GtProfileDetailsDto>();
}
