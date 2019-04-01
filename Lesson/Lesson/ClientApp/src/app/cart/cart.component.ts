import { Component, OnInit } from '@angular/core';
import { CartService } from '../cart.service';
@Component({
  selector: 'app-cart',
  templateUrl: './cart.component.html',
  styleUrls: ['./cart.component.css']
})
export class CartComponent implements OnInit {

  public result: number ;
  constructor(private cartService: CartService)
  {}

  ngOnInit()
  {
    this.cartService.change.subscribe(result => {
      this.result = result;
    });
  }

}
