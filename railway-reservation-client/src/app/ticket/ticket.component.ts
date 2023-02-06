import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { PassengersService } from '../services/passengers.service';
import { TicketsService } from '../services/tickets.service';

@Component({
  selector: 'app-ticket',
  templateUrl: './ticket.component.html',
  styleUrls: ['./ticket.component.scss']
})
export class TicketComponent implements OnInit{
  constructor(public passengerService: PassengersService, public ticketService: TicketsService, private router:Router, private activatedRoute:ActivatedRoute) {
  }
  passenger: any;
  ticket: any;
  
  ngOnInit() {
    this.passenger = this.passengerService.getPassengerById(Number(localStorage.getItem('passengerId')));
    this.ticket = this.ticketService.getTicket(this.passenger.ticketNumber);
}
}
