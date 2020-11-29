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
        public async Task<List<MenuResult>> GetMenus(int ParentID)
        {
            var res = await _context.Menus.Where(x => x.ParentID == ParentID)
                .Select(i => new MenuResult()
                {
                   MenuName = i.MenuName,
                   Description = i.Description,
                   IconClass = i.IconClass,
                   IsVisible =i.IsVisible,
                   MenuOrder = i.MenuOrder
                }).ToListAsync();
           
            return res;
        }
    }
}
