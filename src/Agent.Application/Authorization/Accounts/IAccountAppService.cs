using System.Threading.Tasks;
using Abp.Application.Services;
using Agent.Authorization.Accounts.Dto;

namespace Agent.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
