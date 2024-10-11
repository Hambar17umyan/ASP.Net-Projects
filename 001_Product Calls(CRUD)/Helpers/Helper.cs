using _001_Product_Calls_CRUD_.Models.Domain_Models;
using _001_Product_Calls_CRUD_.Models.DTOs;
using _001_Product_Calls_CRUD_.Models.Request_Models;
using _001_Product_Calls_CRUD_.Models.Response_Models;

internal static class Helper
{
    public static Product CreateProduct(NewProductInfo newProduct)
    {
        return new Product(newProduct.Name, newProduct.Description, newProduct.Category);
    }

    public static Product CreateProduct(ProductRequestModel request)
    {
        return new Product(request.Name, request.Description, request.Category);
    }

    public static ProductResponseModel CreateProductResponse(Product product)
    {
        return new ProductResponseModel(product.Id, product.Name, product.Description, product.Category);
    }
}