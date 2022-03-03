using Hiver.Application.System.Roles;
using Hiver.BackendApi.Auth;
using Hiver.ViewModels.System.Roles;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Hiver.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class RolesController : ControllerBase
    {
        private readonly IRoleService _roleService;

        public RolesController(IRoleService roleService)
        {
            _roleService = roleService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var roles = await _roleService.GetAll();
            return Ok(roles);
        }

        [HttpGet("paging")]
        public async Task<IActionResult> GetAllPaging([FromQuery] GetRolePagingRequest request)
        {
            var roles = await _roleService.GetRolesPaging(request);
            return Ok(roles);
        }

        //[HttpPost]
        //public async Task<IActionResult> RoleCheck([FromBody]RoleCheckVm request)
        //{
        //    var rel = await _roleService.roleCheck(request);
        //    return Ok(rel);
        //}
    }
}