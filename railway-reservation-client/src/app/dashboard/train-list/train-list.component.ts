import { Component, Input, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { TrainService } from 'src/app/services/train.service';

@Component({
  selector: 'app-train-list',
  templateUrl: './train-list.component.html',
  styleUrls: ['./train-list.component.scss']
})
export class TrainListComponent implements OnInit { 

  constructor(public trainService:TrainService) { }

  ngOnInit(): void {
    this.trainService.getTrain(JSON.parse(localStorage.getItem('trainForm')|| '{}')).subscribe();
  }
}
