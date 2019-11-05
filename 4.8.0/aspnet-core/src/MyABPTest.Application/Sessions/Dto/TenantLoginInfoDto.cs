using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using MyABPTest.MultiTenancy;

namespace MyABPTest.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}
