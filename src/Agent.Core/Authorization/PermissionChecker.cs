using Abp.Authorization;
using Agent.Authorization.Roles;
using Agent.Authorization.Users;

namespace Agent.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
