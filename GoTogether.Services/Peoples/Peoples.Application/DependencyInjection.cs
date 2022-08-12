﻿using MediatR;

using Microsoft.Extensions.DependencyInjection;

using System.Reflection;

namespace Peoples.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddProfileApplication(this IServiceCollection services)
    {
        services.AddMediatR(Assembly.GetExecutingAssembly());

        return services;
    }
}
