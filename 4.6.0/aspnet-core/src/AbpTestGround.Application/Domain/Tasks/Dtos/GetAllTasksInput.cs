using AbpTestGround.Domain.Tasks;

namespace Acme.SimpleTaskApp.Tasks.Dtos
{
    public class GetAllTasksInput
    {
        public TaskState? State { get; set; }
    }
}