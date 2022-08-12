
global using Microsoft.EntityFrameworkCore;
global using Microsoft.EntityFrameworkCore.Metadata.Builders;
global using Microsoft.Extensions.Configuration;
global using Microsoft.Extensions.DependencyInjection;

global using Npgsql;

global using Peoples.Application.Contracts.DbContext;
global using Peoples.Application.Contracts.Repositories;
global using Peoples.Application.CQRS.Profiles.Commands.UpdateGtProfile;
global using Peoples.Application.CQRS.Profiles.Queries.GetGtProfile;
global using Peoples.Domain;
global using Peoples.Infrastructure.Persistance;