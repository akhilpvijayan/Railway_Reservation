import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { TrainService } from '../services/train.service';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.scss']
})
export class DashboardComponent implements OnInit {

  constructor( public trainService : TrainService) { }

  ngOnInit(): void {
  }
  onSubmit(form: NgForm) {
      this.getTrain(form);
  }
  getTrain(form: NgForm) {
      this.trainService.getTrain(form).subscribe()  
    }
}
