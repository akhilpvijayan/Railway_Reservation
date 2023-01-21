import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { BookingModalComponent } from 'src/app/booking-modal/booking-modal.component';

@Component({
  selector: 'app-cell-customt',
  templateUrl: './cell-customt.component.html',
  styleUrls: ['./cell-customt.component.scss']
})
export class CellCustomComponent implements OnInit {
  data: any;
  params: any;
  constructor(private http: HttpClient,private dialog: MatDialog) {}

  agInit(params: { value: any; }) {
    this.params = params;
    this.data = params.value;
  }

  ngOnInit() {}

  addBooking() {
    let rowData = this.params;
    let i = rowData.rowIndex;
    console.log(rowData.data);
    const dialogRef = this.dialog.open(BookingModalComponent);
  }
}
