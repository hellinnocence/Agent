using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Agent.Authorization.Roles;
using Agent.Authorization.Users;
using Agent.MultiTenancy;

namespace Agent.EntityFrameworkCore
{
    public class AgentDbContext : AbpZeroDbContext<Tenant, Role, User, AgentDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public AgentDbContext(DbContextOptions<AgentDbContext> options)
            : base(options)
        {
        }
    }
}
