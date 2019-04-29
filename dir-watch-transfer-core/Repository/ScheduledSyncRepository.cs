using DirWatchTransfer.Core.Entity;
using DirWatchTransfer.Core.Enum;
using DirWatchTransfer.Core.Interface;
using DirWatchTransfer.DB;

namespace DirWatchTransfer.Core.Repository
{
    [InjectionConfig(RequestInjectionState.Scoped)]
    public class ScheduledSyncRepository : BaseRepository<ScheduledSync>, IInjection
    {

    }
}
