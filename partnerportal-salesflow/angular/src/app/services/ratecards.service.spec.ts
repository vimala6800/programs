import { TestBed } from '@angular/core/testing';

import { RatecardsService } from './ratecards.service';

describe('RatecardsService', () => {
  let service: RatecardsService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(RatecardsService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
