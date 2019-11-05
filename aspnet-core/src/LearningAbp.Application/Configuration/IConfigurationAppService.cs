using System.Threading.Tasks;
using LearningAbp.Configuration.Dto;

namespace LearningAbp.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
