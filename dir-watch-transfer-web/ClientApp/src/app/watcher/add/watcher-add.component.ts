import { Component, OnInit } from '@angular/core';
import { SymbolicLinkService } from '../../services/symbolic-link.service';
import SymbolicLink from '../../model/symbolic-link';
import { WatcherService } from '../../services/watcher.service';

@Component({
  selector: 'watcher-add',
  templateUrl: './watcher-add.component.html',
  styleUrls: ['./watcher-add.component.css'],
  providers: [WatcherService]
})
export class WatcherAddComponent implements OnInit {
  watcher: any = {};
  symbolicLinks: Array<SymbolicLink> = [];

  constructor(private watcherService: WatcherService, private symbolicLinkService: SymbolicLinkService) { }

  ngOnInit() {
    this.symbolicLinks = this.symbolicLinkService.symbolicLinks
  }

  addWatcher() {
    this.watcherService.addWatcher(this.watcher).subscribe();
  }
}
