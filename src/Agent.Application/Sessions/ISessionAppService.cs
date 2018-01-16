using System.Threading.Tasks;
using Abp.Application.Services;
using Agent.Sessions.Dto;

namespace Agent.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
