import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Tickets } from '../shared/tickets';

@Injectable({
  providedIn: 'root'
})
export class TicketsService {
  formData:Tickets=new Tickets();
  tickets!: Tickets[];
  constructor(private httpClient: HttpClient) { }
  //get tickets
  getAllTickest(){
    this.httpClient.get(environment.apiUrl + '/tickets')
    .toPromise().then(
      response => this.tickets = response as Tickets[])
  }

  //insert a ticket
  addTicket(tickets: Tickets): Observable<any> {
    return this.httpClient.post(environment.apiUrl + "/tickets/", tickets);

  }

  //get particular ticket
  getTicket(ticketId: number): Observable<any> {
    return this.httpClient.get(environment.apiUrl + '/tickets/' + ticketId);
    
  }
}
