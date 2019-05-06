using DirWatchTransfer.Core.Entity;
using DirWatchTransfer.Core.Interface;
using DirWatchTransfer.Core.Model;
using DirWatchTransfer.Core.Repository;
using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace DirWatchTransfer.Core.Utility
{
    [InjectionConfig(Enum.RequestInjectionState.NotInjected)]
    public class LogUtility : IInjection
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

                byte[] newline = Encoding.ASCII.GetBytes(Environment.NewLine);
                await fileStream.WriteAsync(newline, 0, newline.Length);
            }
        }

        public static void OpenDirectory()
        {
            System.Diagnostics.Process.Start(Environment.GetEnvironmentVariable("WINDIR") + @"\explorer.exe", Constants.ApplicationPath);
        }

        public static async Task<string> GetLog()
        {
            string content = await File.ReadAllTextAsync(Constants.LogFilePath);
            return content;
        }
    }
}
