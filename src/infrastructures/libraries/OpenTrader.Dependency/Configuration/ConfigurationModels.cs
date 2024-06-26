﻿using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OpenTrader.Exchange.Service.Models.Configuration;

namespace OpenTrader.Dependency.Configuration;

public static class ConfigurationModels
{
    /// <summary>
    ///     Add to service collection S3Settings
    /// </summary>
    /// <param name="builder"></param>
    /// <exception cref="InvalidOperationException">if dont exists in config file</exception>
    /// <returns></returns>
    public static WebApplicationBuilder AddS3Settings(this WebApplicationBuilder builder)
    {
        var s3Settings = builder.Configuration
            .GetSection(nameof(S3Settings))
            .Get<S3Settings>();

        if (s3Settings is null) throw new InvalidOperationException($"{nameof(S3Settings)} dont exists in config file");

        builder.Services.AddSingleton(s3Settings);

        return builder;
    }
}