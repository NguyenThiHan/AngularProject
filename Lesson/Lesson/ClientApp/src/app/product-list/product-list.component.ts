import { Component, OnInit, Input } from '@angular/core';
import { Product} from '../Model/Product';
import { ProductKindService } from '../product-kind.service';
import { CartService } from '../cart.service';

@Component({
  selector: 'app-product-list',
  templateUrl: './product-list.component.html',
  styleUrls: ['./product-list.component.css']
})
export class ProductListComponent implements OnInit {

  public flag: boolean;

  curentProductDetailId: number;

  @Input() set productKindId(id)
  {
    this.getProduct(id);
  }

  //@Input() flatCancel: boolean;

  public product: Product[];
  constructor(private productService: ProductKindService,
    private cartService: CartService) { }

  ngOnInit() {
  }

  getProduct(id): void {
    this.productService.getProductList(id).subscribe(product =>
      this.product = product);
  }
  //details
  productDetailClick(id) {
    this.flag = true;
    this.curentProductDetailId = id;
  }
  //cong vao gio hang
  addClick() {
    this.cartService.countItem();
  }
}
