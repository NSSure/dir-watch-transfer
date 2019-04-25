import { Component } from '@angular/core';

@Component({
  selector: 'watcher-list',
  templateUrl: './watcher-list.component.html',
  styleUrls: ['./watcher-list.component.css']
})
export class WatcherListComponent {
  isExpanded = false;

  collapse() {
    this.isExpanded = false;
  }

  toggle() {
    this.isExpanded = !this.isExpanded;
  }
}
