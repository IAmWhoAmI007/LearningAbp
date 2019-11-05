using System.Threading.Tasks;
using MyABPTest.Configuration.Dto;

namespace MyABPTest.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
