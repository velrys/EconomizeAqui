using System.Threading.Tasks;
using Abp.Application.Services;
using EconomizeAqui.Sessions.Dto;

namespace EconomizeAqui.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
