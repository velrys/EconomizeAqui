using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace EconomizeAqui.EntityFrameworkCore
{
    public static class EconomizeAquiDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<EconomizeAquiDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<EconomizeAquiDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
