import { TestBed } from '@angular/core/testing';

import { QuotionService } from './quotion.service';

describe('QuotionService', () => {
  let service: QuotionService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(QuotionService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
