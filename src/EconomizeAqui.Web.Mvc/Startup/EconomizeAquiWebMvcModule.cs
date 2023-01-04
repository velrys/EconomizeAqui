using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using EconomizeAqui.Configuration;

namespace EconomizeAqui.Web.Startup
{
    [DependsOn(typeof(EconomizeAquiWebCoreModule))]
    public class EconomizeAquiWebMvcModule : AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public EconomizeAquiWebMvcModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void PreInitialize()
        {
            Configuration.Navigation.Providers.Add<EconomizeAquiNavigationProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(EconomizeAquiWebMvcModule).GetAssembly());
        }
    }
}
