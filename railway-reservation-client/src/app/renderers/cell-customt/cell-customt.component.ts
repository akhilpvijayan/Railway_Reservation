import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { ActivatedRoute, Router } from '@angular/router';
import { BookingModalComponent } from 'src/app/booking-modal/booking-modal.component';

@Component({
  selector: 'app-cell-customt',
  templateUrl: './cell-customt.component.html',
  styleUrls: ['./cell-customt.component.scss']
})
export class CellCustomComponent implements OnInit {
  data: any;
  params: any;
  constructor(private http: HttpClient,private dialog: MatDialog,    private router: Router,private route: ActivatedRoute) {}

  agInit(params: { value: any; }) {
    this.params = params;
    this.data = params.value;
  }

  ngOnInit() {}

  addBooking() {
    let rowData = this.params;
    let i = rowData.rowIndex;
    console.log(rowData.data);
    localStorage.setItem('trainData',JSON.stringify(rowData.data));
    this.router.navigate(['/booking']);
  }
}
