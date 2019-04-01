import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ProductKindComponent } from './product-kind.component';

describe('ProductKindComponent', () => {
  let component: ProductKindComponent;
  let fixture: ComponentFixture<ProductKindComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ProductKindComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ProductKindComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
