using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Services
{
    public interface IUserService
    {
        bool AddUser(User user);
        bool UpdateUser(User user);
        bool DeleteUser(int id);
        User GetUserById(int id);
        List<User> GetUsers();
    }
}
