import { Injectable } from '@angular/core';
import { BaseService } from './base-service';

@Injectable()
export class LogService extends BaseService {
  get apiUrl() {
    return `${this.baseUrl}log/`
  }

  openDirectory() {
    this.http.get(this.apiUrl + 'open/directory').subscribe();
  }
}
