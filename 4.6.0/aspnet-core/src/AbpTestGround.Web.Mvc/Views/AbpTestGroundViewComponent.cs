using Abp.AspNetCore.Mvc.ViewComponents;

namespace AbpTestGround.Web.Views
{
    public abstract class AbpTestGroundViewComponent : AbpViewComponent
    {
        protected AbpTestGroundViewComponent()
        {
            LocalizationSourceName = AbpTestGroundConsts.LocalizationSourceName;
        }
    }
}
