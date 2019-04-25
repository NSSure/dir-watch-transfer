import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { SyncListComponent } from './sync/sync-list.component';
import { WatcherListComponent } from './watcher/watcher-list.component';
import { SymbolicLinkAddComponent } from './symbolic-link/quick-add/symbolic-link-add.component';
import { SymbolicLinkListComponent } from './symbolic-link/list/symbolic-link-list.component';
import { SyncAddComponent } from './sync/quick-add/sync-add.component';

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
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
