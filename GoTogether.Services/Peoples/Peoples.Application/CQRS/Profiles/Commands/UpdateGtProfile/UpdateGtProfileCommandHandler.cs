namespace Peoples.Application.CQRS.Profiles.Commands.UpdateGtProfile;

public class UpdateGtProfileCommandHandler : IRequestHandler<UpdateGtProfileCommand>
{
    private readonly IGtProfileRepository _repository;
    private readonly IMapper _mapper;

    public UpdateGtProfileCommandHandler(IGtProfileRepository repository, IMapper mapper)
        => (_repository, _mapper) = (repository, mapper);

    public async Task<Unit> Handle(UpdateGtProfileCommand request, CancellationToken cancellationToken)
    {
        var profileToUpdate = await _repository.GetGtProfileAsync(request.Id, cancellationToken);

        if (profileToUpdate == null)
            throw new NotFoundException(nameof(GtProfile), request.Id);

        profileToUpdate.NickName = request.NickName ?? profileToUpdate.NickName;
        profileToUpdate.LocationId = request.LocationId == Guid.Empty ? profileToUpdate.LocationId : request.LocationId;
        profileToUpdate.EMail = request.EMail ?? profileToUpdate.EMail;
        profileToUpdate.About = request.About ?? profileToUpdate.About;
        profileToUpdate.Age = request.Age ?? profileToUpdate.Age;
        profileToUpdate.ImageUrl = request.ImageUrl ?? profileToUpdate.ImageUrl;

        await _repository.UpdateGtProfileAsync(profileToUpdate, cancellationToken);

        return Unit.Value;
    }
}
