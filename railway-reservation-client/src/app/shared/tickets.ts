import { AppRoutingModule } from "../app-routing.module";

export class Tickets {
    ticketId!: number;
    ticktNumber!: string;
    ticketStatus!: string;
    userId!: number;
    bookedDate!: Date;
    journeyDate!: Date;
    ticktFare!: number;
    trainId!: number;
}
