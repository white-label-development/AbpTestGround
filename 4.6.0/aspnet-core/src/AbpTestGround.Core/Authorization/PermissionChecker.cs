using Abp.Authorization;
using AbpTestGround.Authorization.Roles;
using AbpTestGround.Authorization.Users;

namespace AbpTestGround.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
