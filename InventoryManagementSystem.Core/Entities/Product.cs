namespace InventoryManagementSystem.Core.Entities
{
    public class Product : BaseEntity
    {

        public string? Name { get; set; }
        public int CategoryId { get; set; }

        public string? Description { get; set; }
        public int StockQuantity { get; set; }
    }
}