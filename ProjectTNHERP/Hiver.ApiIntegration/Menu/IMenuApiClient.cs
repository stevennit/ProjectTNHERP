using Hiver.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Hiver.ApiIntegration.Menu
{
    public interface  IMenuApiClient
    {
        Task<List<MenuResult>> GetMenus(int? ParentID);
    }
}
