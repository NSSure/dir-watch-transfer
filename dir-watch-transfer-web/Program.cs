using DirWatchTransfer.Core;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace DirWatchTransfer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Initialize application directory.
            if (!Directory.Exists(Constants.ApplicationPath))
            {
                Directory.CreateDirectory(Constants.ApplicationPath);
            }

            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) => WebHost
            .CreateDefaultBuilder(args)
            .UseUrls("http://localhost:9876/")
            .UseStartup<Startup>();
    }
}
