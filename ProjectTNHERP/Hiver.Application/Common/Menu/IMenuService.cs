using Hiver.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Hiver.Application.Common.Menu
{
    public interface IMenuService
    {
        Task<List<MenuResult>> GetMenu(int Id);
        Task<List<MenuResult>> GetMenuParent(int? parentId);
    }
}
