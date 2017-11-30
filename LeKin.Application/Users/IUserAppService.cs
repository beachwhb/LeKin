using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using LeKin.Roles.Dto;
using LeKin.Users.Dto;

namespace LeKin.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UpdateUserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();
    }
}