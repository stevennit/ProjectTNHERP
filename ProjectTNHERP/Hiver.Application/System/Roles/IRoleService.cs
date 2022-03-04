using Hiver.ViewModels.Common;
using Hiver.ViewModels.System.Roles;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Hiver.Application.System.Roles
{
    public interface IRoleService
    {
        Task<ApiResult<PagedResult<RoleVm>>> GetRolesPaging(GetRolePagingRequest request);

        Task<ApiResult<bool>> roleCheck(string userName, RoleCheckVm request);

        Task<List<RoleVm>> GetAll();

        Task<ApiResult<bool>> Create(RoleCreateRequest request);

        Task<ApiResult<bool>> Update(Guid id, RoleUpdateRequest request);

        Task<ApiResult<RoleVm>> GetById(Guid id);

        Task<ApiResult<bool>> Delete(Guid id);

    }
}