using DirWatchTransfer;
using DirWatchTransfer.Api;
using DirWatchTransfer.Core.Enum;
using System;
using System.Collections.Generic;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class RepositoryDependencyInjectionExtensions
    {
        public static void AddInjections(this IServiceCollection services)
        {
            List<Type> repositories = RepositoryLookup.ListIRepositoryClasses();

            repositories.ForEach((repository) =>
            {
                InjectionConfigAttribute repositoryConfig = Attribute.GetCustomAttribute(repository, typeof(InjectionConfigAttribute)) as InjectionConfigAttribute;

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
                            case RequestInjectionState.NotInjected:
                                // Do nothing class is not being injected.
                                break;
                            default:
                                throw new Exception("The request injection state supplied for the repository is not an allowed value.");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{repository.FullName} - is being ignored through its InjectionConfigAttribute. So you will not be able to use DI to resolve this member.");
                    }
                }
                else
                {
                    Console.WriteLine($"{repository.FullName} - is not decorated with the InjectionConfigAttribute. So you will not be able to use DI to resolve this member.");
                }
            });
        }
    }
}
