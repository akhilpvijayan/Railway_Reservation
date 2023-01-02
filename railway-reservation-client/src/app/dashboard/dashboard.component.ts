import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { StationsService } from '../services/stations.service';
import { TrainTypesService } from '../services/train-types.service';
import { TrainService } from '../services/train.service';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.scss']
})
export class DashboardComponent implements OnInit {

  constructor( public trainService : TrainService, public stationService: StationsService, public trainTypeService : TrainTypesService) { }

  ngOnInit(): void {
    this.stationService.getStations();
    this.trainTypeService.getTrainTypes();
  }
  onSubmit(form: NgForm) {
      this.getTrain(form);
  }
  getTrain(form: NgForm) {
      this.trainService.getTrain(form).subscribe()  
    }
}
