using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using EconomizeAqui.Configuration.Dto;

namespace EconomizeAqui.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : EconomizeAquiAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
