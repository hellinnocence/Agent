using System.Collections.Generic;
using Agent.Roles.Dto;
using Agent.Users.Dto;

namespace Agent.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
