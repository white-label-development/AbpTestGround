using System.Threading.Tasks;
using AbpTestGround.Configuration.Dto;

namespace AbpTestGround.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
