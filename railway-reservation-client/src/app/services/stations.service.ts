import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { Stations } from '../shared/stations';

@Injectable({
  providedIn: 'root'
})
export class StationsService {
  formData:Stations=new Stations();
  stations !: Stations[];
  constructor(private httpClient: HttpClient) { }
  //get stations
  getStations(){
    this.httpClient.get(environment.apiUrl + '/stations')
    .toPromise().then(
      response => this.stations = response as Stations[])
  }
}
