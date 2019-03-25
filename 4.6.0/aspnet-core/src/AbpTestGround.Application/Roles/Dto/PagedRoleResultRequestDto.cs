using Abp.Application.Services.Dto;

namespace AbpTestGround.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

