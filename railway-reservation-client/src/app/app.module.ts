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
import { AgGridModule } from 'ag-grid-angular';
import { CellCustomComponent } from './renderers/cell-customt/cell-customt.component';
import { MatDialogModule } from '@angular/material/dialog';
import { BookingComponent } from './booking/booking.component';
import { AgmCoreModule, GoogleMapsAPIWrapper } from '@agm/core';
import { AgmDirectionModule } from 'agm-direction';

@NgModule({
  declarations: [
    AppComponent,
    PassengersComponent,
    AddPassengerComponent,
    DashboardComponent,
    LoginComponent,
    TrainsComponent,
    StationsComponent,
    TrainListComponent,
    CellCustomComponent,
    BookingComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    CommonModule,
    ReactiveFormsModule,
    AgGridModule,
    MatDialogModule,
    AgmDirectionModule,
    AgmCoreModule.forRoot({
      apiKey: ''
    }) ,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }