import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import SymbolicLink from '../model/symbolic-link';

@Injectable()
export class SymbolicLinkService {
    constructor(private http: HttpClient) { }

    configUrl = 'http://localhost:8081/api/symbolic/link/';

    httpOptions = {
        headers: new HttpHeaders({
            'Content-Type': 'application/json'
        })
    };

    addSymbolicLink(symbolicLink: SymbolicLink) {
        return this.http.post(this.configUrl + 'add', symbolicLink, this.httpOptions);
    }

    listSymbolicLinks() {
        return this.http.get<Array<SymbolicLink>>(this.configUrl + 'list');
    }
}
