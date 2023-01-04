using Abp.Application.Services.Dto;

namespace EconomizeAqui.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

