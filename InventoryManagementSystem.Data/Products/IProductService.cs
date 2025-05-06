using InventoryManagementSystem.Core.Entities;

namespace InventoryManagementSystem.Data.Products
{
    public interface IProductService
    {
        List<ProductWithCategoryDto> AllProductsWithCategory();

        //Product GetById(int id);
        void Add(Product product);
        void Delete(int id);
        void Update(Product product);
        string? GetAll();
        string? ProductWithCategory();
        object GetProductById(int id);
    }
}

