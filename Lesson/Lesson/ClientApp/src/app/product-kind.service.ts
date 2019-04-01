import { Injectable } from '@angular/core';
import { Observable } from 'rxjs/Observable';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { ProductKind } from './Model/ProductKind';
import { Product } from './Model/Product';
import { ProductDetail } from './Model/ProductDetail';
@Injectable()

export class ProductKindService {

  constructor(private http: HttpClient) { }

  private productKindUrl = 'api/ProductKind/GetProductKinds';
  private productListUrl = 'api/ProductList/GetProductList/?id='
  private productDetailUrl = 'api/ProductDetail/GetProductDetail/?id=';
  private addproductUrl = 'api/ProductList/PostProduct/';
  private updateproductUrl=""

  getProductKind(): Observable<ProductKind[]>
  {
    return this.http.get<ProductKind[]>(this.productKindUrl);
  }
  //lay danhn sach len
  getProductList(productKindId): Observable<Product[]> {
    return this.http.get<Product[]>(this.productListUrl + productKindId);
  }
  //lay ra detail san pham
  getProductDetails(productId): Observable<ProductDetail> {
    return this.http.get<ProductDetail>(this.productDetailUrl + productId);
  }
  //add product
  addProductInToList(product): Observable<Product>
  {
    return this.http.post<Product>(this.addproductUrl, product);
  }

}
