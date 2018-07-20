import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {RouterModule, Routes } from "@angular/router";
import { TavernService } from "./tavern-service.service";
import { HttpClientModule } from "@angular/common/http";

import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { TavernViewComponent } from './tavern-view/tavern-view.component';
import { AddOrRemoveReviewComponent } from './add-or-remove-review/add-or-remove-review.component';

const appRoutes: Routes = [
  { path: '', component: HomeComponent }
 
];

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    TavernViewComponent,
    AddOrRemoveReviewComponent
  ],
  imports: [
    BrowserModule,
    RouterModule.forRoot(appRoutes),
    HttpClientModule
  ],
  providers: [
    TavernService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
