using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace AbpTestGround.EntityFrameworkCore
{
    public static class AbpTestGroundDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<AbpTestGroundDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<AbpTestGroundDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
