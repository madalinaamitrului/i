using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Services
{
    public class UserService : IUserService
    {
        private readonly List<User> _users;
        public UserService()
        {
            _users = new List<User>();
        }
        public bool AddUser(User user)
        {
            if (user == null)
            {
                return false;
            }
            else
            {
                _users.Add(user);

                return true;
            }
        }
        public bool UpdateUser(User updatedUser)
        { 
                if (updatedUser == null)
                {
                    return false;
                }
                var user = GetUserById(updatedUser.Id);

                if (user == null)
                {
                    return false;
                }
                else
                {
                    user = updatedUser;
                }

                return true;
            
        }
        public bool DeleteUser(int id)
        {
            var user = GetUserById(id);

            if (user == null)
            {
                return false;
            }
            else
            {
                _users.Remove(user);

                return true;
            }
        }
        public User GetUserById(int id)
        {
            return _users.FirstOrDefault(user => user.Id == id);
        }
        public List<User> GetUsers()
        {
            return _users;
        }
        
    }
}