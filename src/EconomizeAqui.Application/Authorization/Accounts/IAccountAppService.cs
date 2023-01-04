using System.Threading.Tasks;
using Abp.Application.Services;
using EconomizeAqui.Authorization.Accounts.Dto;

namespace EconomizeAqui.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
