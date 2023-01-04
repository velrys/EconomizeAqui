using Abp.AutoMapper;
using EconomizeAqui.Roles.Dto;
using EconomizeAqui.Web.Models.Common;

namespace EconomizeAqui.Web.Models.Roles
{
    [AutoMapFrom(typeof(GetRoleForEditOutput))]
    public class EditRoleModalViewModel : GetRoleForEditOutput, IPermissionsEditViewModel
    {
        public bool HasPermission(FlatPermissionDto permission)
        {
            return GrantedPermissionNames.Contains(permission.Name);
        }
    }
}
