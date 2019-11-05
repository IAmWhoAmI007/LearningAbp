using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using MyABPTest.Configuration;
using MyABPTest.Web;

namespace MyABPTest.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class MyABPTestDbContextFactory : IDesignTimeDbContextFactory<MyABPTestDbContext>
    {
        public MyABPTestDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<MyABPTestDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            MyABPTestDbContextConfigurer.Configure(builder, configuration.GetConnectionString(MyABPTestConsts.ConnectionStringName));

            return new MyABPTestDbContext(builder.Options);
        }
    }
}
