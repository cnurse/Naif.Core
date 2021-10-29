using System;
using System.Linq;
using Naif.Core.Constants;
using Naif.Core.Models;

namespace Naif.Core.Framework
{
    public static class UserExtensions
    {
        public static bool IsInRole(this User user, string roleName)
        {
            if (roleName == RoleNames.Everyone || roleName == RoleNames.Registered)
            {
                return true;
            }
            return user.Roles.Any(role => String.Equals(role.Name, roleName, StringComparison.OrdinalIgnoreCase));
        }
    }
}