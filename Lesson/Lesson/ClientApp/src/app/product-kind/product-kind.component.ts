import { Component, OnInit } from '@angular/core';
import { ProductKindService } from '../product-kind.service';
import { ProductKind } from '../Model/ProductKind';
import { Title } from '@angular/platform-browser';

@Component({
  selector: 'app-product-kind',
  templateUrl: './product-kind.component.html',
  styleUrls: ['./product-kind.component.css']
})

export class ProductKindComponent implements OnInit {

 
  public productKind: ProductKind[];
  curentProductKindId: number;
  title: 'SmartPhone';
  constructor(private productKindService: ProductKindService) { }

  ngOnInit() {
    this.getProductKind();
  }

  getProductKind(): void {
    this.productKindService.getProductKind().subscribe(productKind =>
      this.productKind = productKind);
  }

  productKindClick(id) {
    this.curentProductKindId = id;
  }

}
