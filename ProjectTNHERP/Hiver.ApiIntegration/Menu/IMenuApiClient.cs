using Hiver.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Hiver.ApiIntegration.Menu
{
    public interface  IMenuApiClient
    {
        Task<MenuMain> GetMenus(int Id);
        Task<List<MenuViewModel>> GetMenuParent(int? parentId);
    }
}
