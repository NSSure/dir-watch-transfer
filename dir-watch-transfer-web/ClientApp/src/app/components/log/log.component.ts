import { Component, OnInit } from '@angular/core';
import { LogService } from '../../services/log.service';

@Component({
  selector: 'log',
  templateUrl: './log.component.html',
})
export class LogComponent implements OnInit {
  log: string = "";

  constructor(private logService: LogService) { }

  ngOnInit() {
    this.logService.getLog().subscribe((log) => this.log = log.value);
  }
}
