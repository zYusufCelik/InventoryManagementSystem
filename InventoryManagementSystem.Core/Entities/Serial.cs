namespace InventoryManagementSystem.Core.Entities
{
    public class Serial : BaseEntity
    {

        public int ProductId { get; set; }
        public bool IsAvailable { get; set; }

    }
}