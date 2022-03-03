using Hiver.ViewModels.Catalog.Menus;
using Hiver.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Hiver.Application.Common.Menu
{
    public interface IMenuService
    {
        Task<MenuResult> GetMenuItem(int Id);
        Task<List<MenuResult>> GetChildrenMenu(int? parentId, int? menuOrder);

        Task<ApiResult<PagedResult<MenuVm>>> GetUsersPagings(GetMenuPagingRequest request);

        Task<ApiResult<bool>> RegisterUser(MenuCreateRequest request);

        Task<ApiResult<bool>> UpdateUser(Guid id, MenuUpdateRequest request);

        Task<ApiResult<MenuVm>> GetById(Guid id);

        Task<ApiResult<bool>> Delete(Guid id);
    }
}
