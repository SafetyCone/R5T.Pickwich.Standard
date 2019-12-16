using System;

using Microsoft.Extensions.Configuration;

using R5T.Norsica.Standard;


namespace R5T.Pickwich.Standard
{
    public static class IConfigurationBuilderExtensions
    {
        public static IConfigurationBuilder AddVisualStudioProjectFileOperatorConfiguration(this IConfigurationBuilder configurationBuilder, IServiceProvider configurationServiceProvider)
        {
            configurationBuilder.AddDotnetConfiguration(configurationServiceProvider);

            return configurationBuilder;
        }
    }
}
