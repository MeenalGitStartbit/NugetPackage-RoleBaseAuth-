using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleBasedAuthLib.Models
{
    public class User
    {
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public List<string> Roles { get; set; } = new();
    }
}
