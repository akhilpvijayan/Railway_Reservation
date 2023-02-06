import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { PassengersService } from 'src/app/services/passengers.service';

@Component({
  selector: 'app-add-passenger',
  templateUrl: './add-passenger.component.html',
  styleUrls: ['./add-passenger.component.scss']
})
export class AddPassengerComponent implements OnInit {

  Id!: number;
  UserId!: number;
  checkActive!: boolean;
  constructor(
    public passengerService: PassengersService,
    private router: Router,
    private route: ActivatedRoute
  ) { }

  ngOnInit(): void {
    this.passengerService.formData.passengerId = this.UserId;


    if (this.Id != 0 || this.Id != null) {
      //getEmployee
      this.passengerService.getPassengerById(this.Id).subscribe(
        data => {
          console.log(data);


          this.passengerService.formData = data;
          this.checkActive = data.IsActive;


        },
        error => console.log(error)
      );
    }

  }
  onSubmit(form: NgForm) {
    let Id = this.passengerService.formData.passengerId;
    
      this.addPassenger(form);
  }

  addPassenger(form: NgForm) {
    console.log("50%");
    console.log(form.value);
    this.passengerService.addPassenger(form.value).subscribe(
      (result) => {
        console.log(result);
        this.resetForm(form);
      }
    )
  }

    //Clear all contents at loading
    resetForm(form?: NgForm) {
      if (form != null) {
        form.resetForm();
      }
    }
}
