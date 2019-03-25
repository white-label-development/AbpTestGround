using System.Collections.Generic;
using AbpTestGround.Roles.Dto;
using AbpTestGround.Users.Dto;

namespace AbpTestGround.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
