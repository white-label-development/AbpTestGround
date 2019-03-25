using System.Threading.Tasks;
using Abp.Application.Services;
using AbpTestGround.Authorization.Accounts.Dto;

namespace AbpTestGround.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
