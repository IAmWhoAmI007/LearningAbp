using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using MyABPTest.Authorization.Roles;
using MyABPTest.Authorization.Users;
using MyABPTest.MultiTenancy;

namespace MyABPTest.EntityFrameworkCore
{
    public class MyABPTestDbContext : AbpZeroDbContext<Tenant, Role, User, MyABPTestDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public MyABPTestDbContext(DbContextOptions<MyABPTestDbContext> options)
            : base(options)
        {
        }
    }
}
