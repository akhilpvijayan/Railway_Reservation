import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { DashboardComponent } from './dashboard/dashboard.component';
import { LoginComponent } from './login/login.component';
import { AddPassengerComponent } from './passengers/add-passenger/add-passenger.component';
import { PassengersComponent } from './passengers/passengers.component';
import { TrainsComponent } from './trains/trains.component';

const routes: Routes = [
  { path: 'home', component: DashboardComponent},
  { path: 'login', component: LoginComponent},
  { path: 'passengers', component: PassengersComponent },
  { path: 'trains', component: TrainsComponent},
  { path: 'addPassenger', component: AddPassengerComponent }]

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
