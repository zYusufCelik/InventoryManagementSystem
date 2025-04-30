using InventoryManagementSystem.Core.Entities;
using InventoryManagementSystem.Data.Users;
using System.Net.Http;

public class UserClass
{
    private readonly IUserService _userService;

    public UserClass(IUserService userService)
    {
        _userService = userService;
    }

    public string UserLogin(string username, string password)
    {
        var response = _userService.GetUser(username,password);
        if (response != null)
        {
            return response.Role;

        }
        else
        {
            return string.Empty;
        }
    }
}