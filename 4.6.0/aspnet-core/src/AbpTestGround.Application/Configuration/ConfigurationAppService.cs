using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using AbpTestGround.Configuration.Dto;

namespace AbpTestGround.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : AbpTestGroundAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
