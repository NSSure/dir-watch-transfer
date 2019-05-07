import { Injectable } from '@angular/core';
import { BaseService } from './base-service';
import Settings from '../model/settings';

@Injectable()
export class SettingsService extends BaseService {
  get apiUrl() {
    return `${this.baseUrl}settings/`
  }

  private _settings: Settings;

  get settings(): any {
    return this._settings;
  }

  get() {
    return this.http.get<Settings>(this.apiUrl + 'get').toPromise().then(settings => {
      this._settings = settings;
    });
  }

  reinitializeDatabase() {
    return this.http.get(this.apiUrl + 'destructive/database/reinitialize')
  }
}
