using DirWatchTransfer.Core.Enum;
using System;

namespace DirWatchTransfer
{
    public class InjectionConfigAttribute : Attribute
    {
        public RequestInjectionState RequestInjectionState;
        public bool IsIgnored;

        public InjectionConfigAttribute(RequestInjectionState requestInjectionState)
        {
            this.RequestInjectionState = requestInjectionState;
        }

        public InjectionConfigAttribute(RequestInjectionState requestInjectionState, bool isIgnored = false)
        {
            this.RequestInjectionState = requestInjectionState;
            this.IsIgnored = isIgnored;
        }
    }
}
