import { Component } from '@angular/core';
import { SymbolicLinkService } from 'src/app/services/symbolic-link.service';
import SymbolicLink from 'src/app/model/symbolic-link';

@Component({
  selector: 'symbolic-link-add',
  templateUrl: './symbolic-link-add.component.html',
  styleUrls: ['./symbolic-link-add.component.css'],
  providers: [SymbolicLinkService]
})
export class SymbolicLinkAddComponent {
    symbolicLink: SymbolicLink = new SymbolicLink();

    constructor(private symbolicLinkService: SymbolicLinkService) {

    }

    add () {
      this.symbolicLinkService.addSymbolicLink(this.symbolicLink).subscribe();
    }
}
