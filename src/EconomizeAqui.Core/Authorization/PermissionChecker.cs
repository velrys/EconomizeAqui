using Abp.Authorization;
using EconomizeAqui.Authorization.Roles;
using EconomizeAqui.Authorization.Users;

namespace EconomizeAqui.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
