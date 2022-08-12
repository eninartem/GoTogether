namespace Peoples.Application.CQRS.Profiles.Queries.GetGtProfile;

public class GetGtProfileQueryHandler : IRequestHandler<GetGtProfileQuery, GtProfileDto>
{
    private readonly IGtProfileRepository _repository;
    private readonly IMapper _mapper;

    public GetGtProfileQueryHandler(IGtProfileRepository repository, IMapper mapper)
        => (_repository, _mapper) = (repository, mapper);

    public async Task<GtProfileDto> Handle(GetGtProfileQuery request, CancellationToken cancellationToken)
    {
        var profile = await _repository.GetGtProfileAsync(request.Id, cancellationToken);

        if (profile == null)
            throw new NotFoundException(nameof(GtProfile), request.Id);

        return _mapper.Map<GtProfileDto>(profile);
    }
}
