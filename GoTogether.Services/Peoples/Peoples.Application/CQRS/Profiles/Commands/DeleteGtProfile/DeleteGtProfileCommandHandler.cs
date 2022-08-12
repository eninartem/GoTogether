namespace Peoples.Application.CQRS.Profiles.Commands.DeleteGtProfile;

public class DeleteGtProfileCommandHandler : IRequestHandler<DeleteGtProfileCommand>
{
    private readonly IGtProfileRepository _repository;

    public DeleteGtProfileCommandHandler(IGtProfileRepository repository) =>
        _repository = repository;

    public async Task<Unit> Handle(DeleteGtProfileCommand request, CancellationToken cancellationToken)
    {
        var profileToDelete = await _repository.GetGtProfileAsync(request.Id, cancellationToken);

        if (profileToDelete == null)
            throw new NotFoundException(nameof(GtProfile), request.Id);

        await _repository.DeleteGtProfileAsync(profileToDelete, cancellationToken);

        return Unit.Value;
    }
}
