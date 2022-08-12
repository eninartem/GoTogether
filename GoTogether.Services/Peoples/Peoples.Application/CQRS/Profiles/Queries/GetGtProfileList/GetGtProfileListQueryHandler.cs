namespace Peoples.Application.CQRS.Profiles.Queries.GetGtProfileList;

public class GetGtProfileListQueryHandler : IRequestHandler<GetGtProfileListQuery, List<GtProfileDto>>
{
    private readonly IGtProfileRepository _repository;
    private readonly IMapper _mapper;

    public GetGtProfileListQueryHandler(IGtProfileRepository repository, IMapper mapper)
        => (_repository, _mapper) = (repository, mapper);

    public async Task<List<GtProfileDto>> Handle(GetGtProfileListQuery request, CancellationToken cancellationToken)
    {
        var profileList = await _repository.GetGtProfileListAsync(cancellationToken);

        return _mapper.Map<List<GtProfileDto>>(profileList);
    }
}
