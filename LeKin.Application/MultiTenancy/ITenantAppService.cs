using Abp.Application.Services;
using Abp.Application.Services.Dto;
using LeKin.MultiTenancy.Dto;

namespace LeKin.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
