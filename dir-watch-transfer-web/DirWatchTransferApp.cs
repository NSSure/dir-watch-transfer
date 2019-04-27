using DirWatchTransfer.SignalR;
using Microsoft.AspNetCore.SignalR;
using Microsoft.AspNetCore.SignalR.Client;
using System.Collections.Generic;

namespace DirWatchTransfer
{
    public class DirWatchTransferApp
    {   
        public static IHubContext<FileSystemHub> FileSystemHub { get; set; }
        public static HubConnection HubConnection { get; set; }
    }   
}
