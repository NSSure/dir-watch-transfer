import { Component } from '@angular/core';
import ScheduledSync from 'src/app/model/scheduled-sync';

@Component({
  selector: 'sync-add',
  templateUrl: './sync-add.component.html',
  styleUrls: ['./sync-add.component.css']
})
export class SyncAddComponent {
  scheduledSync: ScheduledSync = new ScheduledSync();
}
