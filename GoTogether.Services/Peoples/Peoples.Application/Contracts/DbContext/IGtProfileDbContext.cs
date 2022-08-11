using Microsoft.EntityFrameworkCore;

using Peoples.Domain;

namespace Peoples.Application.Contracts.DbContext;

public interface IGtProfileDbContext
{
    DbSet<GtProfile> Profiles { get; set; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
