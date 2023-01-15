import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { NgForm } from '@angular/forms';
import { ColDef, SideBarDef } from 'ag-grid-community';
import { Observable } from 'rxjs';
import { CellCustomComponent } from 'src/app/renderers/cell-customt/cell-customt.component';
import { StationsService } from 'src/app/services/stations.service';
import { TrainTypesService } from 'src/app/services/train-types.service';
import { TrainService } from 'src/app/services/train.service';

@Component({
  selector: 'app-train-list',
  templateUrl: './train-list.component.html',
  styleUrls: ['./train-list.component.scss']
})
export class TrainListComponent  {
  rowData:any;
  selectedSource: any;
  constructor( public trainService : TrainService,  public stationService: StationsService, public trainTypeService : TrainTypesService) { 
    this.rowData = this.trainService.getTrains(localStorage.getItem('trainType')|| '{}',localStorage.getItem('source')||
    '{}',localStorage.getItem('destination')|| '{}');
  }
    columnDefs: ColDef[] = [
      { headerName: 'Train',field: 'trainName' ,sortable: true, headerTooltip: "The Train Name",headerClass: 'grid-header'},
      { headerName: 'Source', field: 'source' ,sortable: true,headerClass: 'grid-header'},
      { headerName: 'Destination',field: 'destination' ,sortable: true,headerClass: 'grid-header'},
      { headerName: 'GL',field: 'generalSeats' ,sortable: true, width: 50,headerClass: 'grid-header', headerTooltip: "Number of General Seats", cellStyle: params => {
        if (params.value === 0) {
            return {backgroundColor: 'red'};
        }
        else{
          return {backgroundColor: 'green'};
      }
    }},
    { headerName: 'S-SL', field: 'semiSleeperSeats' ,sortable: true, filter: true,width: 50, headerTooltip: "Number of Semi-Sleeper Seats", cellStyle: params => {
      if (params.value === 0) {
          return {backgroundColor: 'red'};
      }
      else{
        return {backgroundColor: 'green'};
    }
    }},
      { headerName: 'SL', field: 'sleeperSeats' ,sortable: true, filter: true, width: 50, headerTooltip: "Number of Sleeper Seats", cellStyle: params => {
        if (params.value === 0) {
            return {backgroundColor: 'red'};
        }
        else{
          return {backgroundColor: 'green'};
      }
    }}, 
      { headerName: 'AC', field: 'acSeats' ,sortable: true, filter: true,width: 60, headerTooltip: "Number of AC Seats" ,cellStyle: params => {
        if (params.value === 0) {
            return {backgroundColor: 'red'};
        }
        else{
          return {backgroundColor: 'green'};
      }
    }},
    { headerName: 'Type',field: 'trainType' ,sortable: true,headerClass: 'grid-header'},
    { headerName: 'Actons', field: 'actions', cellRendererFramework: CellCustomComponent}
    ];

    ngOnInit(): void {
      this.stationService.getStations();
      this.trainTypeService.getTrainTypes();
      this.selectedSource = this.stationService.getStationById(Number(localStorage.getItem('source')));
    }

    onSubmit(form: NgForm) {
      this.rowData = this.trainService.getTrain(form);
  }

  addBooking(){

  }
    rowStyle = { background: '#2a67d0b5' ,color: 'white'};
    rowClass = 'grid-rows';
    suppressRowHoverHighlight = true;
}