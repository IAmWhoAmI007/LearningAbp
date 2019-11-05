using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using LearningAbp.Configuration;
using LearningAbp.Web;

namespace LearningAbp.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class LearningAbpDbContextFactory : IDesignTimeDbContextFactory<LearningAbpDbContext>
    {
        public LearningAbpDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<LearningAbpDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            LearningAbpDbContextConfigurer.Configure(builder, configuration.GetConnectionString(LearningAbpConsts.ConnectionStringName));

            return new LearningAbpDbContext(builder.Options);
        }
    }
}
