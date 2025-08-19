using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RoleBasedAuthLib.Services;
using Microsoft.Extensions.DependencyInjection;

namespace RoleBasedAuthLib.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddRoleBasedAuth(this IServiceCollection services)
        {
            services.AddSingleton<IAuthService, AuthService>();
            return services;
        }
    }
}
