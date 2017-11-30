using Abp.Authorization;
using LeKin.Authorization.Roles;
using LeKin.Authorization.Users;

namespace LeKin.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
