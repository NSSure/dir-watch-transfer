using DirWatchTransfer.Core.Entity;
using DirWatchTransfer.Core.Enum;
using DirWatchTransfer.Core.Interface;
using DirWatchTransfer.DB;

namespace DirWatchTransfer.Core.Repository
{
    [RepositoryConfig(RequestInjectionState.Scoped)]
    public class ActivityHistoryRepository : BaseRepository<ActivityHistory>, IRepository
    {

    }
}
