import { AgmCoreModule, GoogleMapsAPIWrapper } from '@agm/core';
import { DatePipe } from '@angular/common';
import { Component, NgModule, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Route } from '@angular/router';
import { PassengersService } from '../services/passengers.service';
import { TicketsService } from '../services/tickets.service';
import { ActivatedRoute, Router } from '@angular/router';


@Component({
  selector: 'app-booking',
  templateUrl: './booking.component.html',
  styleUrls: ['./booking.component.scss'],
  providers: [DatePipe]
})

export class BookingComponent implements OnInit {
  constructor(public passengerService : PassengersService, public ticketService : TicketsService, private datePipe: DatePipe, private router: Router) { }

  public lat = 24.799448;
  public lng = 120.979021;
  public trainData = JSON.parse(localStorage.getItem('trainData') || '{}');
  public trainType = this.trainData.trainType;
  public trainName = this.trainData.trainName;
  public origin: any;
  public destination: any;
  public id: any;
  myDate = new Date();
  
  ngOnInit() {
    this.getDirection();
  }

  getDirection() {
    this.origin = { lat: 24.799448, lng: 120.979021 };
    this.destination = { lat: 24.799524, lng: 120.975017 };
  
    // Location within a string
    // this.origin = 'Taipei Main Station';
    // this.destination = 'Taiwan Presidential Office';
  }
  onSubmit(form: NgForm){
    form.value.startingPoint = this.trainData.source;
    form.value.destination = this.trainData.destination;
    this.passengerService.addPassenger(form.value).subscribe(
      (result) => {
        console.log(result);
        this.addTicket(form, result[0].passengerId)
      });
  }
  addTicket(form: NgForm, passengerId:number){
    form.value.trainId = this.trainData.trainId;
    form.value.bookedDate = this.datePipe.transform(this.myDate, 'yyyy-MM-dd');
    this.ticketService.addTicket(form.value).subscribe(
      (result) => {
        console.log(result);
        this.updatePassenger(form, result[0].ticketId,passengerId);
        return true;
      } 
  )
  }
  updatePassenger(form: NgForm, id: number, passengerId:number){
    form.form.value.ticketNumber = id.toString();
    form.form.value.passengerId = passengerId;
    this.passengerService.updatePassenger(form.value).subscribe(
      (result) => {
        console.log(result);
      } )
    localStorage.setItem('passengerId',form.form.value.passengerId);
    this.router.navigate(['/ticket']);
  }
}
