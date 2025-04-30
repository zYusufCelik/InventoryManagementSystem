using InventoryManagementSystem.Data.Products;


public class ProductClass
{
    private readonly IProductService _productService;
    public ProductClass(IProductService ProductService)
    {
        _productService = ProductService;
    }

    public List<ProductWithCategoryDto> ProductWithCategory()
    {
        List<ProductWithCategoryDto> pwc = new List<ProductWithCategoryDto>();

        var response = _productService.GetAllProductsWithCategory();
        if (response != null)
        {
            return response;

        }
        else
        {
            return pwc;
        }
    }

}

