using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DirWatchTransfer
{
    public class ConnectionManager
    {
        public static async Task Connect()
        {
            HubConnection connection = new HubConnectionBuilder().WithUrl($"http://localhost:44318/hub").Build();

            // Executed when the some entity is added on a server.
            connection.On("FileCopied", () =>
            {
                var t = string.Empty;
            });

            await connection.StartAsync();
            await connection.SendAsync("FileCopied");
        }
    }
}
