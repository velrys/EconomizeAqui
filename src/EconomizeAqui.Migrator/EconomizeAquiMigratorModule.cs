using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using EconomizeAqui.Configuration;
using EconomizeAqui.EntityFrameworkCore;
using EconomizeAqui.Migrator.DependencyInjection;

namespace EconomizeAqui.Migrator
{
    [DependsOn(typeof(EconomizeAquiEntityFrameworkModule))]
    public class EconomizeAquiMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public EconomizeAquiMigratorModule(EconomizeAquiEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(EconomizeAquiMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                EconomizeAquiConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(EconomizeAquiMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
