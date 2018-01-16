using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Agent.EntityFrameworkCore
{
    public static class AgentDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<AgentDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<AgentDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
