import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl } from '@angular/forms';
import { ProductKindService } from '..//product-kind.service';
import { Product } from '../Model/Product';

@Component({
  selector: 'app-insert-product',
  templateUrl: './insert-product.component.html',
  styleUrls: ['./insert-product.component.css']
})
export class InsertProductComponent implements OnInit {

  constructor(private service: ProductKindService){ }

  ngOnInit() {
    this.onSubmit();
  }
  public product: Product;

  insertProduct = new FormGroup({
    id: new FormControl(''),
    productkindid: new FormControl(''),
    nameproduct: new FormControl(''),
  });

  onSubmit()
  {
    this.service.addProductInToList(this.insertProduct.value).subscribe(product => this.product = product);
    //return this.insertProduct.value();
  }
}
