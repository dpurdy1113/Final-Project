import { TestBed, inject } from '@angular/core/testing';

import { TavernServiceService } from './tavern-service.service';

describe('TavernServiceService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [TavernServiceService]
    });
  });

  it('should be created', inject([TavernServiceService], (service: TavernServiceService) => {
    expect(service).toBeTruthy();
  }));
});
