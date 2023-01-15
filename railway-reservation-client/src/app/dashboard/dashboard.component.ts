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

  ngOnInit(): void {
    this.stationService.getStations();
    this.trainTypeService.getTrainTypes();
  }
  onSubmit(form: NgForm) {
      this.getTrain(form);
  }
  getTrain(form: NgForm) {
    localStorage.setItem('trainType',form.value.TrainType);
    localStorage.setItem('destination',form.value.Destination);
    localStorage.setItem('source',form.value.Source);
      this.router.navigate(['/trainsList', { form: form.value }]);
      //this.trainService.getTrain(form).subscribe()  
    }
}
