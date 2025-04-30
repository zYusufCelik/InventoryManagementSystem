﻿namespace InventoryManagementSystem.Core.Entities
{
    public class OrderItem : BaseEntity
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }

        public int Quantity { get; set; }

    }
}