using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using EconomizeAqui.Authorization.Roles;
using EconomizeAqui.Authorization.Users;
using EconomizeAqui.MultiTenancy;

namespace EconomizeAqui.EntityFrameworkCore
{
    public class EconomizeAquiDbContext : AbpZeroDbContext<Tenant, Role, User, EconomizeAquiDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public EconomizeAquiDbContext(DbContextOptions<EconomizeAquiDbContext> options)
            : base(options)
        {
        }
    }
}
