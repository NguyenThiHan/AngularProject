import { TestBed, inject } from '@angular/core/testing';

import { ProductKindService } from './product-kind.service';

describe('ProductKindService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [ProductKindService]
    });
  });

  it('should be created', inject([ProductKindService], (service: ProductKindService) => {
    expect(service).toBeTruthy();
  }));
});
