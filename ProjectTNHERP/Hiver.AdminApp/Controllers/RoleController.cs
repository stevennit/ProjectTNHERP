using Hiver.ApiIntegration;
using Hiver.ViewModels.System.Roles;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
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

        //[CustomAttributes.Authorize("Role_View", "admin")]
        //public async Task<IActionResult> Index(string keyword, int pageIndex = 1, int pageSize = 10)
        //{
        //    var request = new GetRolePagingRequest()
        //    {
        //        Keyword = keyword,
        //        PageIndex = pageIndex,
        //        PageSize = pageSize
        //    };
        //    var data = await _roleApiClient.GetRolePagingRequest(request);
        //    ViewBag.Keyword = keyword;

        //    if (TempData["result"] != null)
        //    {
        //        ViewBag.SuccessMsg = TempData["result"];
        //    }
        //    return View(data.ResultObj);
        //}
    }
}
