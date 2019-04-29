import { Component, OnInit } from '@angular/core';
import { ActivityService } from '../../services/activity.service';

@Component({
  selector: 'activity',
  templateUrl: './activity.component.html',
})
export class ActivityComponent implements OnInit {
  constructor(private activityService: ActivityService) { }

  ngOnInit() {

  }
}
