using System.Threading.Tasks;
using Abp.Application.Services;
using LeKin.Configuration.Dto;

namespace LeKin.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}