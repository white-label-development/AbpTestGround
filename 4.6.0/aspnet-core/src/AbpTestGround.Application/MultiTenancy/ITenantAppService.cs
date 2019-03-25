using Abp.Application.Services;
using Abp.Application.Services.Dto;
using AbpTestGround.MultiTenancy.Dto;

namespace AbpTestGround.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

