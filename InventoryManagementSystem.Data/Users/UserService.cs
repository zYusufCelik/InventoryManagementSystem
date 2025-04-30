using InventoryManagementSystem.Core.Entities;

namespace InventoryManagementSystem.Data.Users
{
    public class UserService : IUserService
    {
        private readonly AppDbContext _context;
        public UserService(AppDbContext context)
        {
            _context = context;
        }
        public User GetUser(string username, string password)
        {
            var user = _context.Users
                .FirstOrDefault(u => u.UserName == username && u.PasswordHash == password);
            return user;
        }
    }
    
}
