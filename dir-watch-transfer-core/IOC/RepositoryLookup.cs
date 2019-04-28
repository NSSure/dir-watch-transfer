using DirWatchTransfer.Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DirWatchTransfer.Api
{
    public class RepositoryLookup
    {
        public static List<Type> ListIRepositoryClasses()
        {
            return AppDomain.CurrentDomain.GetAssemblies().SelectMany(x => x.GetTypes()).Where(x => typeof(IRepository).IsAssignableFrom(x) && !x.IsInterface && !x.IsAbstract).ToList();
        }
    }
}
