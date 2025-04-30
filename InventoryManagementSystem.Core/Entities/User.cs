namespace InventoryManagementSystem.Core.Entities
{
    public class User : BaseEntity
    {
        public string? UserName { get; set; }
        public string? PasswordHash { get; set; }
        public string? Role { get; set; }
    }
}