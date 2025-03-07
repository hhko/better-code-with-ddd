﻿using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Crop.Hello.Api.Adapters.Infrastructure.Abstractions.Registration;

public static class InfrastructureLayerRegistration
{
    public static IServiceCollection RegisterInfrastructureLayer(
        this IServiceCollection services, 
        IHostEnvironment environment,
        //ILoggingBuilder logging,
        IConfiguration configuration)
    {
        services
            .RegisterOptions()
            //.RegisterOpenTelemetry(logging, environment, configuration);
            .RegisterOpenTelemetry(environment, configuration);

        return services;
    }

    //public static IApplicationBuilder UsePersistenceLayer(this IApplicationBuilder app)
    //{
    //    return app;
    //}
}