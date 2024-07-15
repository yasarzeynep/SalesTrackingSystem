import { ProductModel } from "./products.model";

export class OrderDetailModel{
    id: string = "";
    orderId: string = "";
    productId: string = "";
    product:ProductModel = new ProductModel();
    quantity:number = 0;
    price: number = 0;    
}