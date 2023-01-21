import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CellCustomComponent } from './cell-customt.component';

describe('CellCustomtComponent', () => {
  let component: CellCustomComponent;
  let fixture: ComponentFixture<CellCustomComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CellCustomComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CellCustomComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
