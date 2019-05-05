export default class Settings {
  id: number;
  enableNotifications: boolean;
  enableNewSymbolicLinkNotifications: boolean;
  enableNewWatcherNotifications: boolean;
  enableNewSyncNotifications: boolean;
  enableWatcherFileSyncsNotifications: boolean;
  enableForcedDirectoryCopiesNotifications: boolean;
  logNewSymbolicLinks: boolean;
  logNewWatchers: boolean;
  logNewSyncs: boolean;
  logWatcherFileSyncs: boolean;
  logForcedDirectoryCopies: boolean;
  logFilePath: string;
  logFileFormat: string;
}
