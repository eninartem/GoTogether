
global using MediatR;

global using Microsoft.AspNetCore.Authentication.JwtBearer;
global using Microsoft.AspNetCore.Mvc;

global using Peoples.Application;
global using Peoples.Application.Contracts.DbContext;
global using Peoples.Application.Contracts.Repositories;
global using Peoples.Application.CQRS.Profiles.Commands.CreateGtProfile;
global using Peoples.Application.CQRS.Profiles.Commands.DeleteGtProfile;
global using Peoples.Application.CQRS.Profiles.Commands.UpdateGtProfile;
global using Peoples.Application.Features;
global using Peoples.Infrastructure.Persistance;
global using Peoples.Infrastructure.Repositories;

global using System.Reflection;
