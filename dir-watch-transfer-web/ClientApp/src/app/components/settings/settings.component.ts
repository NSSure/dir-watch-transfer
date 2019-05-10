import { Component } from '@angular/core';
import { SettingsService } from '../../services/settings.service';
import Settings from '../../model/settings';

@Component({
  selector: 'settings',
  templateUrl: './settings.component.html',
})
export class SettingsComponent {
  constructor(private settingsService: SettingsService) { }

  reinitializeDatabase() {
    if (confirm("Are sure your want to reinitialize the database? All existing data will be lost.")) {
      this.settingsService.reinitializeDatabase().subscribe();
      window.location.reload();
    }
  }
}
