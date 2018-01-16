using Abp.AspNetCore.Mvc.ViewComponents;

namespace Agent.Web.Views
{
    public abstract class AgentViewComponent : AbpViewComponent
    {
        protected AgentViewComponent()
        {
            LocalizationSourceName = AgentConsts.LocalizationSourceName;
        }
    }
}
