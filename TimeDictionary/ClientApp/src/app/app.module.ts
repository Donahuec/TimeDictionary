import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { LayoutModule } from '@angular/cdk/layout';
import { MatToolbarModule } from '@angular/material/toolbar';
import { MatButtonModule } from '@angular/material/button';
import { MatSidenavModule } from '@angular/material/sidenav';
import { MatIconModule } from '@angular/material/icon';
import { MatListModule } from '@angular/material/list';
import { NavComponent } from './nav/nav.component';
import { TasksComponent } from './tasks/tasks.component';
import { GroupsComponent } from './groups/groups.component';
import { TagsComponent } from './tags/tags.component';
import { SettingsComponent } from './settings/settings.component';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
    NavComponent,
    TasksComponent,
    GroupsComponent,
    TagsComponent,
    SettingsComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
    { path: '', component: TasksComponent, pathMatch: 'full' },
    { path: 'tasks', component: TasksComponent },
    { path: 'groups', component: GroupsComponent },
    { path: 'tags', component: TagsComponent },
    { path: 'settings', component: SettingsComponent }
], { relativeLinkResolution: 'legacy' }),
    BrowserAnimationsModule,
    LayoutModule,
    MatToolbarModule,
    MatButtonModule,
    MatSidenavModule,
    MatIconModule,
    MatListModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
