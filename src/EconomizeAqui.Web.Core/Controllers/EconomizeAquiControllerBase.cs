using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace EconomizeAqui.Controllers
{
    public abstract class EconomizeAquiControllerBase: AbpController
    {
        protected EconomizeAquiControllerBase()
        {
            LocalizationSourceName = EconomizeAquiConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
