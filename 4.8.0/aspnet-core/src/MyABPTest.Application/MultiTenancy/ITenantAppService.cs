using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MyABPTest.MultiTenancy.Dto;

namespace MyABPTest.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

