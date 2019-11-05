using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using LearningAbp.Configuration.Dto;

namespace LearningAbp.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : LearningAbpAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
