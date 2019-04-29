import { BrowserModule } from '@angular/platform-browser';
import { NgModule, APP_INITIALIZER } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { SyncListComponent } from './sync/sync-list.component';
import { WatcherListComponent } from './watcher/list/watcher-list.component';
import { WatcherAddComponent } from './watcher/add/watcher-add.component';
import { SymbolicLinkAddComponent } from './symbolic-link/quick-add/symbolic-link-add.component';
import { SymbolicLinkListComponent } from './symbolic-link/list/symbolic-link-list.component';
import { SyncAddComponent } from './sync/quick-add/sync-add.component';
import { SymbolicLinkService } from './services/symbolic-link.service';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
    SyncListComponent,
    SyncAddComponent,
    WatcherListComponent,
    WatcherAddComponent,
    SymbolicLinkAddComponent,
    SymbolicLinkListComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'counter', component: CounterComponent },
      { path: 'fetch-data', component: FetchDataComponent },
    ])
  ],
  providers: [
    SymbolicLinkService,
    {
      provide: APP_INITIALIZER,
      useFactory: (symbolicLinkService: SymbolicLinkService) => function () { return symbolicLinkService.listSymbolicLinks() },
      deps: [SymbolicLinkService],
      multi: true
    }
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
