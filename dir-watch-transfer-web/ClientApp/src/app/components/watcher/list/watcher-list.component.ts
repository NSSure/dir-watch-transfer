import { Component, OnInit } from '@angular/core';
import { WatcherService } from 'src/app/services/watcher.service';
import { SymbolicLinkService } from '../../../services/symbolic-link.service';

@Component({
  selector: 'watcher-list',
  templateUrl: './watcher-list.component.html',
  styleUrls: ['./watcher-list.component.css'],
  providers: [WatcherService]
})
export class WatcherListComponent implements OnInit {
  watchers: Array<any> = [];

  constructor(private watcherService: WatcherService, private symbolicLinkService: SymbolicLinkService) {

  }

  ngOnInit() {
    this.watcherService.listWatchers().subscribe((watchers) => {
      this.watchers = watchers

      this.watchers.forEach((watcher) => {
        let symbolicLink = this.symbolicLinkService.symbolicLinks.find(x => x.id == watcher.symbolicLinkID);
        watcher.symbolicLink = symbolicLink;
      })
    });
  }

  startWatcher(watcher) {
    watcher.isRunning = true;
    this.watcherService.startWatcher(watcher.id).subscribe();
  }

  stopWatcher(watcher) {
    watcher.isRunning = false;
    this.watcherService.stopWatcher(watcher.id).subscribe();
  }
}
