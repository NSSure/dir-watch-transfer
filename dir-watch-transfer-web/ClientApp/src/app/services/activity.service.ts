import { Injectable } from '@angular/core';
import { BaseService } from './base-service';

@Injectable()
export class ActivityService extends BaseService {
  testVariable: string = "My test string";
  activityHistory: Array<any> = [];
}
