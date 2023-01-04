using System.Threading.Tasks;
using EconomizeAqui.Configuration.Dto;

namespace EconomizeAqui.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
