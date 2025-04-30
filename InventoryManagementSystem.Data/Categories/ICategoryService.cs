using InventoryManagementSystem.Core.Entities;

namespace InventoryManagementSystem.Data.Categories
{
    public interface ICategoryService
    {
        List<Category> GetAllCategories();
    }
}
