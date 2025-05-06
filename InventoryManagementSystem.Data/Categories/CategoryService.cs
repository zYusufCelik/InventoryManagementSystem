using InventoryManagementSystem.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace InventoryManagementSystem.Data.Categories
{
    public class CategoryService : ICategoryService
    {
        private readonly AppDbContext _context;
        public CategoryService(AppDbContext context)
        {
            _context = context;
        }
        public List<Category> GetAllCategories()
        {
            return _context.Categories.ToList();
            //var categories = _context.Categories.ToList();

            //if(categories is not null)
            //{
            //    return categories;
            //}

            //return null;

        }
    }
}
