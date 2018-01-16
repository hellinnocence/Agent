using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Agent.Roles.Dto;
using Agent.Users.Dto;

namespace Agent.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
