using DirWatchTransfer;
using DirWatchTransfer.Api;
using DirWatchTransfer.Core.Enum;
using System;
using System.Collections.Generic;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class RepositoryDependencyInjectionExtensions
    {
        public static void AddRepositories(this IServiceCollection services)
        {
            List<Type> repositories = RepositoryLookup.ListIRepositoryClasses();

            repositories.ForEach((repository) =>
            {
                RepositoryConfigAttribute repositoryConfig = Attribute.GetCustomAttribute(repository, typeof(RepositoryConfigAttribute)) as RepositoryConfigAttribute;

                if (repositoryConfig != null)
                {
                    if (!repositoryConfig.IsIgnored)
                    {
                        switch (repositoryConfig.RequestInjectionState)
                        {
                            case RequestInjectionState.Scoped:
                                services.AddScoped(repository);
                                break;
                            case RequestInjectionState.Transient:
                                services.AddTransient(repository);
                                break;
                            case RequestInjectionState.Singleton:
                                services.AddSingleton(repository);
                                break;
                            default:
                                throw new Exception("The request injection state supplied for the repository is not an allowed value.");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{repository.FullName} - is being ignored through its RepositoryConfigAttribute. So you will not be able to use DI to resolve this member.");
                    }
                }
                else
                {
                    Console.WriteLine($"{repository.FullName} - is not decorated with the RepositoryConfigAttribute. So you will not be able to use DI to resolve this member.");
                }
            });
        }
    }
}
