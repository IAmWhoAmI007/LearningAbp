using Abp.Application.Services;
using Abp.Application.Services.Dto;
using LearningAbp.MultiTenancy.Dto;

namespace LearningAbp.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

