using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace MyABPTest.EntityFrameworkCore
{
    public static class MyABPTestDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<MyABPTestDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<MyABPTestDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
