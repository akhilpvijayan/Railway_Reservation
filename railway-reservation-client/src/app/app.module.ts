import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { PassengersComponent } from './passengers/passengers.component';
import { HttpClientModule } from '@angular/common/http';
import { AddPassengerComponent } from './passengers/add-passenger/add-passenger.component';
import { FormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';
import { ReactiveFormsModule } from '@angular/forms';
import { DashboardComponent } from './dashboard/dashboard.component';
import { LoginComponent } from './login/login.component';
import { TrainsComponent } from './trains/trains.component';
import { StationsComponent } from './stations/stations.component';
import { TrainListComponent } from './dashboard/train-list/train-list.component';

@NgModule({
  declarations: [
    AppComponent,
    PassengersComponent,
    AddPassengerComponent,
    DashboardComponent,
    LoginComponent,
    TrainsComponent,
    StationsComponent,
    TrainListComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    CommonModule,
    ReactiveFormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
