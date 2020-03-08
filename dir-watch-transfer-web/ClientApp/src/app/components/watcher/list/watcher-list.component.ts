import { Component, OnInit } from '@angular/core';
import { WatcherService } from 'src/app/services/watcher.service';
import { SymbolicLinkService } from '../../../services/symbolic-link.service';
import { Subscription } from 'rxjs';

@Component({
  selector: 'watcher-list',
  templateUrl: './watcher-list.component.html',
  styleUrls: ['./watcher-list.component.css']
})
export class WatcherListComponent implements OnInit {
  groupedWatchers: Array<any> = [];

  newWatcherSubscription: Subscription;

  actionPropertyMap: Array<any> = [
    { name: 'watchFileName', display: 'File name' },
    { name: 'watchDirectoryName', display: 'Directory name' },
    { name: 'watchSize', display: 'Size' },
    { name: 'watchLastWrite', display: 'Last write' },
    { name: 'watchLastAccess', display: 'Last access' },
    { name: 'watchCreationTime', display: 'Creation time' },
    { name: 'watchSecurity', display: 'Security' },
  ];

  constructor(private watcherService: WatcherService, private symbolicLinkService: SymbolicLinkService) {

  }

  ngOnInit() {
    this.newWatcherSubscription = this.watcherService.newWatcher$.subscribe((watcher) => {
      if (watcher) {
        let group = this.groupedWatchers.find(x => x.symbolicLink.id === watcher.symbolicLinkId);

        if (!group) {
          group = {};
          group.watchers = new Array<any>();
          this.groupedWatchers.push(group);
        }

        group.watchers.push(watcher);
      }
    });

    this.watcherService.groupedWatchers().subscribe((groupedWatchers) => {
      this.groupedWatchers = groupedWatchers;

      this.groupedWatchers.forEach((grouped) => {
        let symbolicLink = this.symbolicLinkService.symbolicLinks.find(x => x.id == grouped.symbolicLinkID);
        grouped.symbolicLink = symbolicLink;

        grouped.watchers.forEach((watcher) => {
          watcher.actions = this.buildActionString(watcher);
        });
      });
    });
  }

  ngOnDestroy() {
    this.newWatcherSubscription.unsubscribe();
  }

  buildActionString(watcher) {
    let actions: string = "";

    this.actionPropertyMap.forEach((propertyMap) => {
      if (watcher[propertyMap.name]) {
        if (actions == "") {
          actions = propertyMap.display;
        }
        else {
          actions += `, ${propertyMap.display}`;
        }
      }
    });

    return actions;
  }

  startWatcher(watcher) {
    (<any>window).$Toast.show("Watcher started successfully");
    watcher.isRunning = true;
    this.watcherService.startWatcher(watcher.id).subscribe();
  }

  stopWatcher(watcher) {
    watcher.isRunning = false;
    this.watcherService.stopWatcher(watcher.id).subscribe();
  }

  deleteWatcher(watcher) {
    if (confirm("Are sure you want to delete this watcher?")) {
      this.watcherService.deleteWatcher(watcher.id);
    }
  }
}
