using DirWatchTransfer.Core.Entity;
using DirWatchTransfer.Core.Enum;
using DirWatchTransfer.Core.Interface;
using DirWatchTransfer.Core.Model;
using DirWatchTransfer.DB;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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

        public async Task<List<GroupedWatchers>> GroupBySymbolicLink()
        {
            IEnumerable<IGrouping<int, Watcher>> watchers = (await this.ListAllAsync()).GroupBy(a => a.SymbolicLinkID);

            List<GroupedWatchers> groupedWatchers = new List<GroupedWatchers>();

            foreach (IGrouping<int, Watcher> symbolicLinkWatchers in watchers)
            {
                groupedWatchers.Add(new GroupedWatchers()
                {
                    SymbolicLinkID = symbolicLinkWatchers.Key,
                    Watchers = symbolicLinkWatchers.ToList()
                });
            }

            return groupedWatchers;
        }
    }
}
