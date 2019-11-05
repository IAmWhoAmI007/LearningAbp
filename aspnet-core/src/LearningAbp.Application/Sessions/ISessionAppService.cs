using System.Threading.Tasks;
using Abp.Application.Services;
using LearningAbp.Sessions.Dto;

namespace LearningAbp.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
