using Hiver.ViewModels.Common;
using Hiver.ViewModels.System.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hiver.ApiIntegration
{
    public interface IRoleApiClient
    {
        Task<ApiResult<PagedResult<RoleVm>>> GetAllPaging(GetRolePagingRequest request);
        Task<ApiResult<List<RoleVm>>> GetAll();

        Task<ApiResult<bool>> RoleCreate(RoleCreateRequest request);

        Task<ApiResult<bool>> RoleUpdate(Guid id, RoleUpdateRequest request);

        Task<ApiResult<RoleVm>> GetById(Guid id);

        Task<ApiResult<bool>> Delete(Guid id);

        Task<ApiResult<bool>> roleCheck(string nameUser);
    }
}