using Hiver.ApiIntegration;
using Hiver.ViewModels.System.Roles;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Threading.Tasks;

namespace Hiver.AdminApp.Controllers
{
    public class RoleController : BaseController
    {
        private readonly IRoleApiClient _roleApiClient;
        private readonly IConfiguration _configuration;
        public RoleController(IRoleApiClient roleApiClient,
            IConfiguration configuration)
        {
            _roleApiClient = roleApiClient;
            _configuration = configuration;
        }

        public async Task<IActionResult> Index(string keyword, int pageIndex = 1, int pageSize = 10)
        {
            var request = new GetRolePagingRequest()
            {
                Keyword = keyword,
                PageIndex = pageIndex,
                PageSize = pageSize
            };
            var data = await _roleApiClient.GetAllPaging(request);
            ViewBag.Keyword = keyword;

            if (TempData["result"] != null)
            {
                ViewBag.SuccessMsg = TempData["result"];
            }
            return View(data.ResultObj);
        }

        [HttpGet]
        public async Task<IActionResult> Details(Guid id)
        {
            var result = await _roleApiClient.GetById(id);
            return View(result.ResultObj);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(RoleCreateRequest request)
        {
            if (!ModelState.IsValid)
                return View();

            var result = await _roleApiClient.RoleCreate(request);

            if (result.IsSuccessed)
            {
                TempData["result"] = "Tạo thành công";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", result.Message);
            return View(request);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var result = await _roleApiClient.GetById(id);
            if (result.IsSuccessed)
            {
                var user = result.ResultObj;
                var updateRequest = new RoleUpdateRequest()
                {
                    ControllerName = user.ControllerName,
                    ActionName = user.ActionName,
                    Description = user.Description,
                    Name = user.Name,
                    Id = id
                };
                return View(updateRequest);
            }
            return RedirectToAction("Error", "Home");
        }

        [HttpPost]
        public async Task<IActionResult> Edit(RoleUpdateRequest request)
        {
            if (!ModelState.IsValid)
                return View();

            var result = await _roleApiClient.RoleUpdate(request.Id, request);
            if (result.IsSuccessed)
            {
                TempData["result"] = "Cập nhật thành công";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", result.Message);
            return View(request);
        }
        [HttpGet]
        public IActionResult Delete(Guid id)
        {
            return View(new RoleDeleteRequest()
            {
                Id = id
            });
        }

        [HttpPost]
        public async Task<IActionResult> Delete(RoleDeleteRequest request)
        {
            if (!ModelState.IsValid)
                return View();

            var result = await _roleApiClient.Delete(request.Id);
            if (result.IsSuccessed)
            {
                TempData["result"] = "Xóa thành công";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", result.Message);
            return View(request);
        }
    }
}
