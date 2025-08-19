using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleBasedAuthLib.Attributes
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class, AllowMultiple = true)]
    public class RoleAuthorizeAttribute : Attribute
    {
        public string Role { get; }

        public RoleAuthorizeAttribute(string role)
        {
            Role = role;
        }
    }
}
