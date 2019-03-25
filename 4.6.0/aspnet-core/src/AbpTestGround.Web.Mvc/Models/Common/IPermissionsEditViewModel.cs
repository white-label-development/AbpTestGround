using System.Collections.Generic;
using AbpTestGround.Roles.Dto;

namespace AbpTestGround.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}