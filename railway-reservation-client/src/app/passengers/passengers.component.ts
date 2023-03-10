import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Router } from '@angular/router';
import { PassengersService } from '../services/passengers.service';
import { TrainService } from '../services/train.service';

@Component({
  selector: 'app-passengers',
  templateUrl: './passengers.component.html',
  styleUrls: ['./passengers.component.scss']
})
export class PassengersComponent implements OnInit {

  constructor(public passengerService: PassengersService, public trainService: TrainService, public router: Router) { }
  count: number = 0;
  ngOnInit(): void {
    this.passengerService.getAllPassengers();
  }

  deletePassenger(PassengerId: number) {
    if (confirm("The passenger data will be removed ! Are you sure?")) {
      this.passengerService.deletePassenger(PassengerId).subscribe(
        (result) => {
          console.log(result);
          //this.toasterService.success('Patient Deleted successfully');
        }
      )  
      window.location.reload();

    }
  }
}
