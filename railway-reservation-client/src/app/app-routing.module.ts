import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AddPassengerComponent } from './passengers/add-passenger/add-passenger.component';
import { PassengersComponent } from './passengers/passengers.component';

const routes: Routes = [
  { path: 'passengers', component: PassengersComponent },
  { path: 'addPassenger', component: AddPassengerComponent }]

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
