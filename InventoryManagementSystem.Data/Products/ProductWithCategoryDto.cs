namespace InventoryManagementSystem.Data.Products
{
    public class ProductWithCategoryDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int StockQuantity { get; set; }
        public int CategoryId { get; set; }
        public string? CategoryName { get; set; }
        public string? CreatedBy { get; set; }

    }
}
