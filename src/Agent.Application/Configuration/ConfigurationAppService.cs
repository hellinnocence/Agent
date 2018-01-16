using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Agent.Configuration.Dto;

namespace Agent.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : AgentAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
