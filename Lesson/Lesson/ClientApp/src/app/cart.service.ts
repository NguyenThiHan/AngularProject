import { Injectable, Output, EventEmitter } from '@angular/core';

@Injectable()
export class CartService {

  public count=0;
 
  @Output() change: EventEmitter<number> = new EventEmitter();

  constructor() { }

  countItem()
  {
    this.count = this.count + 1;
    this.change.emit(this.count);
  }
}
