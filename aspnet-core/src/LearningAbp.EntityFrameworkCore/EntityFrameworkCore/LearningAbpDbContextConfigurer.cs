using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace LearningAbp.EntityFrameworkCore
{
    public static class LearningAbpDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<LearningAbpDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<LearningAbpDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
