using Hiver.Application.Common.Menu;
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

        public MenusController(MenuSerivce menuSerivce)
        {
            _menuService = menuSerivce;
        }

        [HttpPost]
        public async Task<IActionResult> GetMenus(int ParentID)
        {
            var res = await _menuService.GetMenus(ParentID);

            return Ok(res);
        }
    }
}
