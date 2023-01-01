import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Trains } from '../shared/trains'

@Injectable({
  providedIn: 'root'
})
export class TrainService {
  formData:Trains=new Trains();
  trains!: Trains[];
  constructor(private httpClient: HttpClient) { }

  //get particular trains
  getTrain(formData: NgForm): Observable<any> {
    return this.httpClient.get(environment.apiUrl + '/Trains/' + formData.form.value.Source + '/' + formData.form.value.Destination + '/' + formData.form.value.TrainType); 
  }
}
