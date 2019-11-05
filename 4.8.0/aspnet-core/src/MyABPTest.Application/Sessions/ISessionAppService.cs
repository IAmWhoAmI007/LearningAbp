using System.Threading.Tasks;
using Abp.Application.Services;
using MyABPTest.Sessions.Dto;

namespace MyABPTest.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
