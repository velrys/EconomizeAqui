using Abp.Application.Services;
using EconomizeAqui.MultiTenancy.Dto;

namespace EconomizeAqui.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

