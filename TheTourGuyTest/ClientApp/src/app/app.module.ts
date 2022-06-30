import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { JediComponent } from './jedi/jedi.component';
import { PersonsService } from './services/persons.service';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    JediComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: JediComponent, pathMatch: 'full' },
      { path: 'jedis', component: JediComponent },
    ])
  ],
  providers: [PersonsService],
  bootstrap: [AppComponent]
})
export class AppModule { }
