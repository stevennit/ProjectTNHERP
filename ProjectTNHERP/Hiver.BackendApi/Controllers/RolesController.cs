using Hiver.Application.System.Roles;
using Hiver.BackendApi.Auth;
using Hiver.ViewModels.System.Roles;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
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

        [HttpPost]
        [ServiceFilter(typeof(AuthAttribute))]
        public async Task<IActionResult> Create([FromBody] RoleCreateRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _roleService.Create(request);
            if (!result.IsSuccessed)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }

        [ServiceFilter(typeof(AuthAttribute))]
        //PUT: http://localhost/api/users/id
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, [FromBody] RoleUpdateRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _roleService.Update(id, request);
            if (!result.IsSuccessed)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }

        [HttpGet("{id}")]
        [ServiceFilter(typeof(AuthAttribute))]
        public async Task<IActionResult> GetById(Guid id)
        {
            var table = await _roleService.GetById(id);
            return Ok(table);
        }

        [HttpDelete("{id}")]
        [ServiceFilter(typeof(AuthAttribute))]
        public async Task<IActionResult> Delete(Guid id)
        {
            var result = await _roleService.Delete(id);
            return Ok(result);
        }
    }
}