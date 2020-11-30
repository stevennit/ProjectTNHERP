using Hiver.Data.EF;
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

        public async Task<List<MenuResult>> GetMenu(int Id)
        {
            return await _context.Menus.Where(x => x.MenuID == Id)
                .Select(i => new MenuResult()
                {
                    MenuID = i.MenuID,
                    MenuName = i.MenuName,
                    Description = i.Description,
                    IconClass = i.IconClass,
                    IsVisible = i.IsVisible,
                    MenuOrder = i.MenuOrder,
                    ParentID = i.ParentID,
                    Url = i.Url
                }).ToListAsync();
        }

        public async Task<List<MenuResult>> GetMenuParent(int? parentId)
        {
            return await _context.Menus.Where(x => x.ParentID == parentId)
                .Select(i => new MenuResult()
                {
                    MenuID = i.MenuID,
                    MenuName = i.MenuName,
                    Description = i.Description,
                    IconClass = i.IconClass,
                    IsVisible = i.IsVisible,
                    MenuOrder = i.MenuOrder,
                    ParentID = i.ParentID,
                    Url = i.Url
                }).ToListAsync();
        }
    }
}
