using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using EconomizeAqui.EntityFrameworkCore;
using EconomizeAqui.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace EconomizeAqui.Web.Tests
{
    [DependsOn(
        typeof(EconomizeAquiWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class EconomizeAquiWebTestModule : AbpModule
    {
        public EconomizeAquiWebTestModule(EconomizeAquiEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(EconomizeAquiWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(EconomizeAquiWebMvcModule).Assembly);
        }
    }
}