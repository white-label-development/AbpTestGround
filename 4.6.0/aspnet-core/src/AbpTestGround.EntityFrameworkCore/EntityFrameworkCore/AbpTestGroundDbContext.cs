using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using AbpTestGround.Authorization.Roles;
using AbpTestGround.Authorization.Users;
using AbpTestGround.MultiTenancy;

namespace AbpTestGround.EntityFrameworkCore
{
    public class AbpTestGroundDbContext : AbpZeroDbContext<Tenant, Role, User, AbpTestGroundDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public AbpTestGroundDbContext(DbContextOptions<AbpTestGroundDbContext> options)
            : base(options)
        {
        }
    }
}
