import * as signalR from '@aspnet/signalr';
import { Injectable } from '@angular/core';
import { ActivityService } from './activity.service';
import CopyDiagnostics from '../model/copy-diagnostics';

@Injectable()
export class SignalRService {
  constructor(private activityService: ActivityService) { }

  init() {
    const connection = new signalR.HubConnectionBuilder().withUrl("http://localhost:8081/hub").build();
    connection.start().catch(err => document.write(err));
    connection.on("onFileCopied", (copyDiagnostics: CopyDiagnostics) => {
      this.activityService.activityHistory.push(copyDiagnostics);
    });
  }
}
