using System.Collections.Generic;
using EconomizeAqui.Roles.Dto;

namespace EconomizeAqui.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}