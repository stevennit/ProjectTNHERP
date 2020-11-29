using Hiver.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Hiver.Application.Common.Menu
{
    public interface IMenuService
    {
        Task<List<MenuResult>> GetMenus(int ParentID);
    }
}
