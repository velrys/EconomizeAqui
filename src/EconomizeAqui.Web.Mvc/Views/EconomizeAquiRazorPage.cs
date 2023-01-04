using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace EconomizeAqui.Web.Views
{
    public abstract class EconomizeAquiRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected EconomizeAquiRazorPage()
        {
            LocalizationSourceName = EconomizeAquiConsts.LocalizationSourceName;
        }
    }
}
