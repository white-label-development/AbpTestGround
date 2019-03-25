using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using AbpTestGround.Domain.Tasks.Dtos;
using Acme.SimpleTaskApp.Tasks.Dtos;

namespace AbpTestGround.Domain.Tasks
{
    public interface ITaskAppService : IApplicationService
    {
        Task<ListResultDto<TaskListDto>> GetAll(GetAllTasksInput input);

        System.Threading.Tasks.Task Create(CreateTaskInput input);
    }
}