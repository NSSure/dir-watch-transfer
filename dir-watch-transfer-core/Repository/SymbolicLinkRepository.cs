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
    public class SymbolicLinkRepository : BaseRepository<SymbolicLink>, IInjection
    {
        public async override Task AddAsync(SymbolicLink entity)
        {
            if ((await this.CountAsync(a => a.Source == entity.Source)) > 0)
            {
                throw new System.Exception("You may currently have a source path specified only once. Please change your source path and try again.");
            }

            await base.AddAsync(entity);
        }

        public async Task IncrementCount(string source, NotifyFilters notifyFilter)
        {
            SymbolicLink symbolicLink = await this.FirstOrDefaultAsync(a => a.Source == source);

            string countPropertyName = DirWatcherTransferApp.SymbolicLinkNotifyFilterCountMap[notifyFilter];
            PropertyInfo propertyInfo = symbolicLink.GetType().GetProperty(countPropertyName);

            int currentCount = ((int)propertyInfo.GetValue(symbolicLink));
            propertyInfo.SetValue(symbolicLink, currentCount++);

            await this.UpdateAsync(symbolicLink);
        }
    }
}
