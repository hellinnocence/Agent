using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Agent.MultiTenancy.Dto;

namespace Agent.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
