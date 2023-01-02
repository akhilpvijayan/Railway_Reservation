import { TestBed } from '@angular/core/testing';

import { TrainTypesService } from './train-types.service';

describe('TrainTypesService', () => {
  let service: TrainTypesService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(TrainTypesService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
