using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using AbpTestGround.Configuration;
using AbpTestGround.Web;

namespace AbpTestGround.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class AbpTestGroundDbContextFactory : IDesignTimeDbContextFactory<AbpTestGroundDbContext>
    {
        public AbpTestGroundDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<AbpTestGroundDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            AbpTestGroundDbContextConfigurer.Configure(builder, configuration.GetConnectionString(AbpTestGroundConsts.ConnectionStringName));

            return new AbpTestGroundDbContext(builder.Options);
        }
    }
}
