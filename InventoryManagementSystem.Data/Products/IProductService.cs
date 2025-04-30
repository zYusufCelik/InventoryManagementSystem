using InventoryManagementSystem.Core.Entities;

namespace InventoryManagementSystem.Data.Products
{
    public interface IProductService
    {
        List<ProductWithCategoryDto> GetAllProductsWithCategory();
        //Product GetById(int id);
        void Add(Product product);
        void Delete(int id);
        void Update(Product product);
         
    }
}

