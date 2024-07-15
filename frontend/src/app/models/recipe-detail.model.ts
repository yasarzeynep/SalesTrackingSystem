import { ProductModel } from "./products.model";


export class RecipeDetailModel{
    id: string = "";
    recipeId: string = "";
    productId: string = "";
    product: ProductModel = new ProductModel();
    quantity: number = 1;
}