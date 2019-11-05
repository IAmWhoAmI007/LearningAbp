using System.Threading.Tasks;
using Abp.Application.Services;
using LearningAbp.Authorization.Accounts.Dto;

namespace LearningAbp.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
