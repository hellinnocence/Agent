using System.Threading.Tasks;
using Agent.Configuration.Dto;

namespace Agent.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
