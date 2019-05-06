using System.ServiceProcess;

namespace DirWatchTransfer.Service
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            ServiceBase[] ServicesToRun;

            ServicesToRun = new ServiceBase[]
            {
                new SyncService()
            };

            ServiceBase.Run(ServicesToRun);
        }
    }
}
