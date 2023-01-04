using System.Collections.Generic;
using EconomizeAqui.Roles.Dto;

namespace EconomizeAqui.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
