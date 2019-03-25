using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using AbpTestGround.Authorization.Roles;
using AbpTestGround.Authorization.Users;
using AbpTestGround.Domain.People;
using AbpTestGround.Domain.Tasks;
using AbpTestGround.MultiTenancy;

namespace AbpTestGround.EntityFrameworkCore
{
    public class AbpTestGroundDbContext : AbpZeroDbContext<Tenant, Role, User, AbpTestGroundDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Task> Tasks { get; set; }
        public DbSet<Person> People { get; set; }

        public AbpTestGroundDbContext(DbContextOptions<AbpTestGroundDbContext> options)
            : base(options)
        {
        }
    }
}
