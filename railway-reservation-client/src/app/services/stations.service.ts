import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
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
  //get particular station
  getStationById(stationId: number): Observable<any> {
    return this.httpClient.get(environment.apiUrl + '/stations/' + stationId);
      
    }
  
}
