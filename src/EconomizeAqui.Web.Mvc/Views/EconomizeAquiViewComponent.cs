using Abp.AspNetCore.Mvc.ViewComponents;

namespace EconomizeAqui.Web.Views
{
    public abstract class EconomizeAquiViewComponent : AbpViewComponent
    {
        protected EconomizeAquiViewComponent()
        {
            LocalizationSourceName = EconomizeAquiConsts.LocalizationSourceName;
        }
    }
}
