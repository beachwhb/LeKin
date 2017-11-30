using System.Threading.Tasks;
using Abp.Application.Services;
using LeKin.Sessions.Dto;

namespace LeKin.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
