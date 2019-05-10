import { Injectable } from '@angular/core';
import { BaseService } from './base-service';
import { BehaviorSubject } from 'rxjs';

@Injectable()
export class WatcherService extends BaseService {
  get apiUrl() {
    return `${this.baseUrl}watcher/`
  }

  private _newWatcherSource = new BehaviorSubject<any>(null);

  newWatcher$ = this._newWatcherSource.asObservable();

  newWatcherAdded(watcher) {
    this._newWatcherSource.next(watcher);
  }

  addWatcher(watcher: any) {
    return this.http.post(this.apiUrl + 'add', watcher, this.httpOptions);
  }

  deleteWatcher(watcherId: any) {
    return this.http.post(this.apiUrl + 'delete', watcherId);
  }

  listWatchers() {
    return this.http.get<Array<any>>(this.apiUrl + 'list');
  }

  groupedWatchers() {
    return this.http.get<any>(this.apiUrl + 'grouped');
  }

  startWatcher(watcherId: number) {
    return this.http.post(this.apiUrl + 'start', watcherId);
  }

  stopWatcher(watcherId: number) {
    return this.http.post(this.apiUrl + 'stop', watcherId);
  }
}
