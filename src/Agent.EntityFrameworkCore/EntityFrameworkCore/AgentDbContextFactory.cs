using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Agent.Configuration;
using Agent.Web;

namespace Agent.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class AgentDbContextFactory : IDesignTimeDbContextFactory<AgentDbContext>
    {
        public AgentDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<AgentDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            AgentDbContextConfigurer.Configure(builder, configuration.GetConnectionString(AgentConsts.ConnectionStringName));

            return new AgentDbContext(builder.Options);
        }
    }
}
