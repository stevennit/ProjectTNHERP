using Hiver.Data.EF;
using Hiver.Utilities.Exceptions;
using Hiver.ViewModels.Catalog.Menus;
using Hiver.ViewModels.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hiver.Application.Common.Menu
{
    public class MenuSerivce : IMenuService
    {
        private readonly HiverDbContext _context;

        public MenuSerivce(HiverDbContext context)
        {
            _context = context;
        }

        public async Task<MenuResult> GetMenuItem(int Id)
        {
            var res = await _context.Menus.Where(x => x.MenuID == Id).FirstOrDefaultAsync();

            var menu = new MenuResult()
            {
                MenuId = res.MenuID,
                MenuName = res.MenuName,
                Description = res.Description,
                IconClass = res.IconClass,
                IconNumber = res.IconNumber,
                IsVisible = res.IsVisible,
                ParentID = res.ParentID,
                MenuOrder = res.MenuOrder,
                Url = res.Url
            };
            return menu;
           
        }

        public async Task<List<MenuResult>> GetChildrenMenu(int? parentId, int? menuOrder)
        {
            return await _context.Menus.Where(x => x.ParentID == parentId && x.MenuOrder == menuOrder).OrderBy(x => x.MenuVisible)
                .Select( i => new MenuResult()
                    {
                        MenuId = i.MenuID,
                        MenuName = i.MenuName,
                        Description = i.Description,
                        IconClass = i.IconClass,
                        IconNumber = i.IconNumber,
                        IsVisible = i.IsVisible,
                        ParentID = i.ParentID,
                        MenuOrder = i.MenuOrder,
                        Url = i.Url
                    }
                ).ToListAsync();
        }

        public async Task<ApiResult<PagedResult<MenuVm>>> GetUsersPagings(GetMenuPagingRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResult<bool>> RegisterUser(MenuCreateRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResult<bool>> UpdateUser(Guid id, MenuUpdateRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResult<MenuVm>> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResult<bool>> Delete(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
