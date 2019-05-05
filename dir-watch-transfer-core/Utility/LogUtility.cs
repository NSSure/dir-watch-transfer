using DirWatchTransfer.Core.Entity;
using DirWatchTransfer.Core.Model;
using DirWatchTransfer.Core.Repository;
using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace DirWatchTransfer.Core.Utility
{
    public class LogUtility
    {
        public static async Task WriteToLog(NotifyFilters? notifyFilter, CopyDiagnostics copyDiagnostics)
        {
            // TODO: Enforce the users log settings.
            Settings defaultSettings = await new SettingsRepository().FirstOrDefaultAsync();

            string logAddendum = $"{System.Enum.GetName(typeof(NotifyFilters), notifyFilter)},{copyDiagnostics.SourcePath},{copyDiagnostics.TargetPath},{copyDiagnostics.ElapsedTime} (ms),{DateTime.Now}";

            using (FileStream fileStream = new FileStream(Constants.LogFilePath, FileMode.Append))
            {
                byte[] logAddendumBytes = new UTF8Encoding(true).GetBytes(logAddendum);
                await fileStream.WriteAsync(logAddendumBytes, 0, logAddendumBytes.Length);
            }
        }
    }
}
