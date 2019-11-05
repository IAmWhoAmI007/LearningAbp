using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace MyABPTest.Controllers
{
    public abstract class MyABPTestControllerBase: AbpController
    {
        protected MyABPTestControllerBase()
        {
            LocalizationSourceName = MyABPTestConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
