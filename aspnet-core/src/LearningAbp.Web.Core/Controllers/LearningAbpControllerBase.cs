using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace LearningAbp.Controllers
{
    public abstract class LearningAbpControllerBase: AbpController
    {
        protected LearningAbpControllerBase()
        {
            LocalizationSourceName = LearningAbpConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
