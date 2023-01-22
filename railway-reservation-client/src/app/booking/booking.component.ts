import { AgmCoreModule, GoogleMapsAPIWrapper } from '@agm/core';
import { Component, NgModule, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { PassengersService } from '../services/passengers.service';


@Component({
  selector: 'app-booking',
  templateUrl: './booking.component.html',
  styleUrls: ['./booking.component.scss']
})

export class BookingComponent implements OnInit {
  constructor(public passengerService : PassengersService) { }

  public lat = 24.799448;
  public lng = 120.979021;
  public trainData = JSON.parse(localStorage.getItem('trainData') || '{}');
  public source = this.trainData.source;
  public origin: any;
  public destination: any;
  
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
    this.passengerService.addPassenger(form.value).subscribe(
      (result) => {
        console.log(result);
      }
    )
  }
  
}
