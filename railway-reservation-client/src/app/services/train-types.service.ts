import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { TrainTypes } from '../shared/train-types';

@Injectable({
  providedIn: 'root'
})
export class TrainTypesService {
  formData:TrainTypes=new TrainTypes();
  trainTypes !: TrainTypes[];
  constructor(private httpClient: HttpClient) { }
  //get train typesS
  getTrainTypes(){
    this.httpClient.get(environment.apiUrl + '/trainTypes')
    .toPromise().then(
      response => this.trainTypes = response as TrainTypes[])
  }
}
