using Abp.Authorization;
using MyABPTest.Authorization.Roles;
using MyABPTest.Authorization.Users;

namespace MyABPTest.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
