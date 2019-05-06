using System.Diagnostics;
using System.ServiceProcess;
using System.Timers;

namespace DirWatchTransfer.Service
{
    public partial class SyncService : ServiceBase
    {
        private int eventId = 1;

        public SyncService()
        {
            InitializeComponent();

            eventLog = new System.Diagnostics.EventLog();

            if (!System.Diagnostics.EventLog.SourceExists("DirWatchTransferServiceSource"))
            {
                System.Diagnostics.EventLog.CreateEventSource("DirWatchTransferServiceSource", "DirWatchTransferServiceLog");
            }

            eventLog.Source = "DirWatchTransferServiceSource";
            eventLog.Log = "DirWatchTransferServiceLog";
        }

        protected override void OnStart(string[] args)
        {
            eventLog.WriteEntry("In OnStart.");

            // Set up a timer that triggers every minute.
            Timer timer = new Timer();
            timer.Interval = 60000; // 60 seconds
            timer.Elapsed += new ElapsedEventHandler(this.OnTimer);
            timer.Start();
        }

        protected override void OnStop()
        {
            eventLog.WriteEntry("In OnStop.");
        }

        public void OnTimer(object sender, ElapsedEventArgs args)
        {
            // TODO: Insert monitoring activities here.
            eventLog.WriteEntry("Monitoring the System", EventLogEntryType.Information, eventId++);
        }
    }
}
