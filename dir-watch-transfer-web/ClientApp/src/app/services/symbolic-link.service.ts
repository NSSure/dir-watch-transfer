import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import SymbolicLink from '../model/symbolic-link';
import { BaseService } from './base-service';

@Injectable()
export class SymbolicLinkService extends BaseService {
  get apiUrl() {
    return `${this.baseUrl}symbolic/link/`
  }

  private _symbolicLinks: Array<SymbolicLink>;

  get symbolicLinks(): any {
    return this._symbolicLinks;
  }

  addSymbolicLink(symbolicLink: SymbolicLink) {
    return this.http.post(this.apiUrl + 'add', symbolicLink, this.httpOptions);
  }

  listSymbolicLinks(): Promise<any> {
    return this.http.get<Array<SymbolicLink>>(this.apiUrl + 'list').toPromise().then(symbolicLinks => {
      this._symbolicLinks = symbolicLinks;
    });
  }
}
