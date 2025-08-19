using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RoleBasedAuthLib.Models;

namespace RoleBasedAuthLib.Services
{
    public interface IAuthService
    {
        bool ValidateUser(string username, string password);
        bool IsInRole(string username, string role);
    }
}
