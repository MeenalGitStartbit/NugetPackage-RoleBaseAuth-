using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RoleBasedAuthLib.Models;

namespace RoleBasedAuthLib.Services
{
    public class AuthService : IAuthService
    {
        private readonly List<User> _users;

        public AuthService()
        {
            _users = new List<User>
            {
                new User { Username = "admin", PasswordHash = "admin123", Roles = new List<string> { "Admin" } },
                new User { Username = "user", PasswordHash = "user123", Roles = new List<string> { "User" } }
            };
        }

        public bool ValidateUser(string username, string password)
        {
            var user = _users.FirstOrDefault(u => u.Username == username);
            return user != null && user.PasswordHash == password;
        }

        public bool IsInRole(string username, string role)
        {
            var user = _users.FirstOrDefault(u => u.Username == username);
            return user?.Roles.Contains(role) ?? false;
        }
    }
}
