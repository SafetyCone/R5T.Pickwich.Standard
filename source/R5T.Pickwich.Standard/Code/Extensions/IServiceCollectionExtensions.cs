using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Lombardy;
using R5T.Norsica.Standard;
using R5T.Pickwich.Default;
using R5T.Pickwich.Norsica;


namespace R5T.Pickwich.Standard
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddVisualStudioProjectFileOperator(this IServiceCollection services)
        {
            services
                .AddSingleton<IVisualStudioProjectFileOperator, DotnetVisualStudioProjectFileOperator>()
                .AddDotnetOperator()
                .AddSingleton<IVisualStudioProjectFilePathProvider, CSharpVisualStudioProjectFilePathProvider>()
                .AddSingleton<IStringlyTypedPathOperator, StringlyTypedPathOperator>()
                .AddSingleton<IFileNameOperator, FileNameOperator>()
                ;

            return services;
        }
    }
}
