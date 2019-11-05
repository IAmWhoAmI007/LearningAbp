using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using MyABPTest.Configuration.Dto;

namespace MyABPTest.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : MyABPTestAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
