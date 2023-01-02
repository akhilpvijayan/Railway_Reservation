import { Component, OnInit } from '@angular/core';
import { StationsService } from '../services/stations.service';
import { TrainTypesService } from '../services/train-types.service';

@Component({
  selector: 'app-stations',
  templateUrl: './stations.component.html',
  styleUrls: ['./stations.component.scss']
})
export class StationsComponent implements OnInit {

  constructor(public stationService: StationsService, public trainTypeService : TrainTypesService) { }

  ngOnInit(): void {
    this.stationService.getStations();
  }

}
