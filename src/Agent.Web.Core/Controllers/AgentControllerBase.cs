using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Agent.Controllers
{
    public abstract class AgentControllerBase: AbpController
    {
        protected AgentControllerBase()
        {
            LocalizationSourceName = AgentConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
