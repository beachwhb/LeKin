using System.Collections.Generic;
using LeKin.Roles.Dto;
using LeKin.Users.Dto;

namespace LeKin.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}