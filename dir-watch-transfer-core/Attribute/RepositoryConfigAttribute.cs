using DirWatchTransfer.Core.Enum;
using System;

namespace DirWatchTransfer
{
    public class RepositoryConfigAttribute : Attribute
    {
        public RequestInjectionState RequestInjectionState;
        public bool IsIgnored;

        public RepositoryConfigAttribute(RequestInjectionState requestInjectionState)
        {
            this.RequestInjectionState = requestInjectionState;
        }

        public RepositoryConfigAttribute(RequestInjectionState requestInjectionState, bool isIgnored = false)
        {
            this.RequestInjectionState = requestInjectionState;
            this.IsIgnored = isIgnored;
        }
    }
}
