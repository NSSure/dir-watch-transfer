import * as signalR from '@aspnet/signalr';
import { Injectable } from '@angular/core';
import { ActivityService } from './activity.service';

@Injectable()
export class SignalRService {
  constructor(private activityService: ActivityService) { }

  init() {
    const connection = new signalR.HubConnectionBuilder().withUrl("http://localhost:8081/hub").build();
    connection.start().catch(err => document.write(err));
    connection.on("onFileCopied", (username: string, message: string) => {
      this.activityService.activityHistory.push({
        title: "Activity history record added"
      });
    });
  }
}
