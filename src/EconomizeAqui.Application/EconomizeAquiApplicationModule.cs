using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using EconomizeAqui.Authorization;

namespace EconomizeAqui
{
    [DependsOn(
        typeof(EconomizeAquiCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class EconomizeAquiApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<EconomizeAquiAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(EconomizeAquiApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
