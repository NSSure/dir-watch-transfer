import { NgModule, APP_INITIALIZER } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { AppComponent } from './app.component';
import { NavMenuComponent } from './components/nav-menu/nav-menu.component';
import { HomeComponent } from './components/home/home.component';
import { SyncListComponent } from './components/sync/sync-list.component';
import { WatcherListComponent } from './components/watcher/list/watcher-list.component';
import { WatcherAddComponent } from './components/watcher/add/watcher-add.component';
import { SymbolicLinkAddComponent } from './components/symbolic-link/quick-add/symbolic-link-add.component';
import { SymbolicLinkListComponent } from './components/symbolic-link/list/symbolic-link-list.component';
import { SyncAddComponent } from './components/sync/quick-add/sync-add.component';
import { SymbolicLinkService } from './services/symbolic-link.service';
import { SignalRService } from './services/signalr.service';
import { ActivityComponent } from './components/activity/activity.component';
import { ActivityService } from './services/activity.service';
import { LogService } from './services/log.service';
import { SettingsComponent } from './components/settings/settings.component';
import { SettingsService } from './services/settings.service';
import { LogComponent } from './components/log/log.component';
import { AboutComponent } from './components/about/about.component';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    SyncListComponent,
    SyncAddComponent,
    WatcherListComponent,
    WatcherAddComponent,
    SymbolicLinkAddComponent,
    SymbolicLinkListComponent,
    ActivityComponent,
    SettingsComponent,
    LogComponent,
    AboutComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'settings', component: SettingsComponent, pathMatch: 'full' },
      { path: 'log', component: LogComponent, pathMatch: 'full' },
      { path: 'about', component: AboutComponent, pathMatch: 'full' },
    ])
  ],
  providers: [
    SignalRService,
    ActivityService,
    SymbolicLinkService,
    LogService,
    SettingsService,
    {
      provide: APP_INITIALIZER,
      useFactory: (symbolicLinkService: SymbolicLinkService, settingsService: SettingsService) => function () {
        return Promise.all([
          symbolicLinkService.listSymbolicLinks(),
          settingsService.get()
        ]);
      },
      deps: [SymbolicLinkService, SettingsService],
      multi: true
    }
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
