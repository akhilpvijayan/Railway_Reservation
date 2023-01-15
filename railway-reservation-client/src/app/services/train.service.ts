import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { TrainDetails } from '../shared/train-details';
import { TrainTypes } from '../shared/train-types';
import { Trains } from '../shared/trains'

@Injectable({
  providedIn: 'root'
})
export class TrainService {
  formData:TrainDetails=new TrainDetails();
  trainDetails!: TrainDetails[];
  constructor(private httpClient: HttpClient) { }

  //get particular trains
  getTrain(formData: NgForm) {
    return this.httpClient.get(environment.apiUrl + '/Trains/' + formData.form.value.Source + '/' + formData.form.value.Destination + '/' + formData.form.value.TrainType); 
  }
  //get particular trains
  getTrains(trainType:string,source:string,destination:string) {
    return this.httpClient.get(environment.apiUrl + '/Trains/' + source + '/' + destination + '/' + trainType)
    .toPromise().then(
      response => this.trainDetails = response as TrainDetails[]); 
  }
}
