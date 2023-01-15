import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CellCustomtComponent } from './cell-customt.component';

describe('CellCustomtComponent', () => {
  let component: CellCustomtComponent;
  let fixture: ComponentFixture<CellCustomtComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CellCustomtComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CellCustomtComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
