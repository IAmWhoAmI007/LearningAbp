using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using LearningAbp.Authorization.Roles;
using LearningAbp.Authorization.Users;
using LearningAbp.MultiTenancy;
using LearningAbp.Tasks;

namespace LearningAbp.EntityFrameworkCore
{
    public class LearningAbpDbContext : AbpZeroDbContext<Tenant, Role, User, LearningAbpDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public DbSet<Task> Tasks { get; set; }

        public LearningAbpDbContext(DbContextOptions<LearningAbpDbContext> options)
            : base(options)
        {
        }
    }
}
