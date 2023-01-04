using System.Collections.Generic;
using EconomizeAqui.Roles.Dto;

namespace EconomizeAqui.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
