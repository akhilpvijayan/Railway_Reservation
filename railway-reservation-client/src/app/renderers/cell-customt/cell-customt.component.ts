import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-cell-customt',
  templateUrl: './cell-customt.component.html',
  styleUrls: ['./cell-customt.component.scss']
})
export class CellCustomComponent implements OnInit {
  data: any;
  params: any;
  constructor(private http: HttpClient) {}

  agInit(params: { value: any; }) {
    this.params = params;
    this.data = params.value;
  }

  ngOnInit() {}

  addBooking() {
    let rowData = this.params;
    let i = rowData.rowIndex;
    console.log(rowData.data);
  }
}
