using DirWatchTransfer.Core.Entity;
using DirWatchTransfer.Core.Enum;
using DirWatchTransfer.Core.Interface;
using DirWatchTransfer.DB;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;

namespace DirWatchTransfer.Core.Repository
{
    [InjectionConfig(RequestInjectionState.Scoped)]
    public class WatcherRepository : BaseRepository<Watcher>, IInjection
    {
        public async Task IncrementCount(Watcher watcher, NotifyFilters notifyFilter)
        {
            string countPropertyName = DirWatcherTransferApp.SymbolicLinkNotifyFilterCountMap[notifyFilter];
            PropertyInfo propertyInfo = watcher.GetType().GetProperty(countPropertyName);

            int currentCount = ((int)propertyInfo.GetValue(watcher));
            propertyInfo.SetValue(watcher, currentCount++);

            await this.UpdateAsync(watcher);
        }
    }
}
