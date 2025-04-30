using InventoryManagementSystem.Core.Entities;

namespace InventoryManagementSystem.Data.Users
{
    public interface IUserService
    {
        User GetUser(string username, string password);
    }
}
