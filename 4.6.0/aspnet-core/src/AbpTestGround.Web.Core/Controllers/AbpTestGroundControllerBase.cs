using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace AbpTestGround.Controllers
{
    public abstract class AbpTestGroundControllerBase: AbpController
    {
        protected AbpTestGroundControllerBase()
        {
            LocalizationSourceName = AbpTestGroundConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
