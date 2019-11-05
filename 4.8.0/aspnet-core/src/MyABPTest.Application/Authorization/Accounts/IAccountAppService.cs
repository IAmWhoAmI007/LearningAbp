using System.Threading.Tasks;
using Abp.Application.Services;
using MyABPTest.Authorization.Accounts.Dto;

namespace MyABPTest.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
