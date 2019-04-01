import { Component, OnInit,Input } from '@angular/core';
import { ProductKindService } from '../product-kind.service';
import { ProductDetail } from '../Model/ProductDetail';

@Component({
  selector: 'app-product-detail',
  templateUrl: './product-detail.component.html',
  styleUrls: ['./product-detail.component.css']
})
export class ProductDetailComponent implements OnInit {

  public flagCancel: boolean;

  @Input() set productDetailId(id) {
    if (id) {
      this.getDetail(id);
    }
  }
  

  public detail: ProductDetail;


  constructor(private productServer: ProductKindService) { }

  ngOnInit() {
  }

  getDetail(id): void {
    this.productServer.getProductDetails(id).subscribe(detail =>
      this.detail = detail
    );
  }
  cancelClick() {
    this.flagCancel = true;
  }
}
