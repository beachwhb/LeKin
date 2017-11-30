using System.Threading.Tasks;
using Abp.Application.Services;
using LeKin.Authorization.Accounts.Dto;

namespace LeKin.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
