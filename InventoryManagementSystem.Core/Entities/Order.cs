namespace InventoryManagementSystem.Core.Entities
{
    public class Order : BaseEntity
    {

        public int UserId { get; set; }
        public string? Status { get; set; }
        public DateTime OrderDate { get; set; }

    }
}