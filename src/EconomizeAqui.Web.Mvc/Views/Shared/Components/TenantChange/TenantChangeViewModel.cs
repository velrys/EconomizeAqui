using Abp.AutoMapper;
using EconomizeAqui.Sessions.Dto;

namespace EconomizeAqui.Web.Views.Shared.Components.TenantChange
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}
