import { Component, OnInit } from '@angular/core';
import { SymbolicLinkService } from 'src/app/services/symbolic-link.service';
import SymbolicLink from 'src/app/model/symbolic-link';

@Component({
  selector: 'symbolic-link-list',
  templateUrl: './symbolic-link-list.component.html',
  styleUrls: ['./symbolic-link-list.component.css'],
  providers: [SymbolicLinkService]
})
export class SymbolicLinkListComponent implements OnInit {
    symbolicLinks: Array<SymbolicLink> = [];

    constructor(private symbolicLinkService: SymbolicLinkService) {

    }

    ngOnInit() {
      this.symbolicLinkService.listSymbolicLinks().subscribe((symbolicLinks) => this.symbolicLinks = symbolicLinks);
    }
}
