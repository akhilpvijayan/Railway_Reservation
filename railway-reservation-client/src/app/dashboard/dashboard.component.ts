import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { NgForm } from '@angular/forms';
import { StationsService } from '../services/stations.service';
import { TrainTypesService } from '../services/train-types.service';
import { TrainService } from '../services/train.service';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.scss']
})
export class DashboardComponent implements OnInit {
  
  constructor( public trainService : TrainService, public stationService: StationsService, public trainTypeService : TrainTypesService,
    private router: Router,
    private route: ActivatedRoute) { }

    trainForm:string = 'trainForm';
  ngOnInit(): void {
    this.stationService.getStations();
    this.trainTypeService.getTrainTypes();
  }
  onSubmit(form: NgForm) {
      this.getTrain(this.trainForm,form);
  }
  getTrain(trainForm:string,form: NgForm) {
    localStorage.setItem(trainForm,JSON.stringify(form));
      this.router.navigate(['/trainsList', { form: form.value }]);
      //this.trainService.getTrain(form).subscribe()  
    }
}
