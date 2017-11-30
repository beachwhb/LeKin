using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using LeKin.Configuration.Dto;

namespace LeKin.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : LeKinAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
