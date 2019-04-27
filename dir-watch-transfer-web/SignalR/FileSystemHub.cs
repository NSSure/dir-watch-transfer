using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace DirWatchTransfer.SignalR
{
    public class FileSystemHub : Hub
    {
        public async Task FileCopied()
        {
            await Clients.All.SendAsync("receiveCopiedFile");
        }

        public async Task DirectoryCopied(long sourcePath, long targetPath)
        {
            await Clients.All.SendAsync("receiveCopiedDirectory", sourcePath, targetPath);
        }
    }
}
