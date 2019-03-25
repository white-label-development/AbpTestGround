using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;

namespace AbpTestGround.Web.Views
{
    public abstract class AbpTestGroundRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected AbpTestGroundRazorPage()
        {
            LocalizationSourceName = AbpTestGroundConsts.LocalizationSourceName;
        }
    }
}
