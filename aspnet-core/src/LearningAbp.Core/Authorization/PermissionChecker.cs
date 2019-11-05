using Abp.Authorization;
using LearningAbp.Authorization.Roles;
using LearningAbp.Authorization.Users;

namespace LearningAbp.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
