import { Component } from '@angular/core';
import { SignalRService } from './services/signalr.service';

import SureToastManager from 'node_modules/vue-sure-toast/src/toast-manager';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  constructor(private signalRService: SignalRService) {
    this.signalRService.init();
    (<any>window).$Toast = new SureToastManager({ position: 'bottom-right', enableManualDismiss: true });
  }
}
