import { Injectable } from '@angular/core';
import { BaseService } from './base-service';

@Injectable()
export class WatcherService extends BaseService {
  get apiUrl() {
    return `${this.baseUrl}watcher/`
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
