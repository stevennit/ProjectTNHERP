using Hiver.Application.Common.Menu;
using Hiver.Application.System.Users;
using Hiver.ViewModels.Common;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hiver.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenusController : ControllerBase
    {
        private readonly IMenuService _menuService;

        public MenusController(IMenuService menuService)
        {
            _menuService = menuService;
        }

        [HttpGet("Getmenu")]
        public async Task<IActionResult> GetMenus(int Id)
        {
            var res = await _menuService.GetMenu(Id);

            return Ok(res);
        }

        [HttpGet("Getmenuparent")]
        public async Task<IActionResult> GetMenuParent(int? parentId)
        {
            var res = await _menuService.GetMenuParent(parentId);

            return Ok(res);
        }
    }
}
