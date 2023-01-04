using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using EconomizeAqui.Configuration;

namespace EconomizeAqui.Web.Host.Startup
{
    [DependsOn(
       typeof(EconomizeAquiWebCoreModule))]
    public class EconomizeAquiWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public EconomizeAquiWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(EconomizeAquiWebHostModule).GetAssembly());
        }
    }
}
