import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { Passengers } from '../shared/passengers';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class PassengersService {
  formData:Passengers=new Passengers();
  passengers!: Passengers[];
  constructor(private httpClient: HttpClient) { }
  //get passengers
  getAllPassengers(){
    this.httpClient.get(environment.apiUrl + '/passengers')
    .toPromise().then(
      response => this.passengers = response as Passengers[])
  }

  //insert a passenger
  addPassenger(passengers: Passengers): Observable<any> {
    return this.httpClient.post(environment.apiUrl + "/passengers/", passengers);

  }

  //update a passenger
  updatePassenger(passengers: Passengers): Observable<any> {
    return this.httpClient.put(environment.apiUrl + "/Passengers",passengers);
  }

  //get particular passenger
  getPassengerById(passengerId: number): Observable<any> {
    return this.httpClient.get(environment.apiUrl + '/Passenegers/' + passengerId); 
    
  }

 //Delete a passenger
 deletePassenger(id:number): Observable<any> {
  return this.httpClient.delete(environment.apiUrl + "/Passengers/" +id);
 }
}
