﻿using Hiver.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Hiver.ApiIntegration.Menu
{
    public interface  IMenuApiClient
    {
        Task<List<MenuViewModel>> GetAllMenuPaging(GetMenuPagingRequest request);
        Task<List<MenuViewModel>> GetChildrenMenu(int? parentId = null, int? menuOrder = null);
        Task<MenuViewModel> GetMenuItem(int Id);
    }
}
