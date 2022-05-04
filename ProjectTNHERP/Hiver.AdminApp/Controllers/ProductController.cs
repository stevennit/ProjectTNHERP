using AspNetCoreHero.ToastNotification.Abstractions;
using Hiver.ApiIntegration.Product;
using Hiver.ApiIntegration.ProductCategory;
using Hiver.ViewModels.Catalog.ProductCategories;
using Hiver.ViewModels.Catalog.Products;
using Hiver.ViewModels.Common;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Hiver.AdminApp.Controllers
{
    public class ProductController : BaseController
    {
        private readonly IProductApiClient _productApiClient;
        private readonly IConfiguration _configuration;
        private readonly IProductCategoryApiClient _categoryApiClient;
        private readonly INotyfService _notyf;

        public ProductController(IProductApiClient productApiClient, 
            IProductCategoryApiClient categoryApiClient,
            IConfiguration configuration,
            INotyfService notyf
            )
        {
            _configuration = configuration;
            _productApiClient = productApiClient;
            _categoryApiClient = categoryApiClient;
            _notyf = notyf;
        }

        public async Task<IActionResult> Index(string code,string name, Guid? categoryId, int pageIndex = 1, int pageSize = 10)
        {
            var request = new GetManageProductPagingRequest()
            {
                Code = code,
                Name = name,
                PageIndex = pageIndex,
                PageSize = pageSize,
                CategoryId = categoryId
            };
            var data = await _productApiClient.GetPagings(request);

            ViewBag.Code = code;
            ViewBag.Name = name;

            var categories = await _categoryApiClient.GetAll();

            ViewBag.Categories = categories.Select(x => new SelectListItem()
            {
                Text = x.Name,
                Value = x.Id.ToString(),
                Selected = categoryId.HasValue && categoryId.Value == x.Id
            });

            if (TempData["result"] != null)
            {
                ViewBag.SuccessMsg = TempData["result"];
            }
            return View(data);
        }

        [HttpGet]
        public async Task<IActionResult> Details(Guid id)
        {
            var result = await _productApiClient.GetById(id);
            return View(result);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Consumes("multipart/form-data")]
        [DisableRequestSizeLimit]
        public async Task<IActionResult> Create([FromForm] ProductCreateRequest request)
        {
            if (!ModelState.IsValid)
                return View(request);

            request.CreateBy = User.Identity.Name;

            var result = await _productApiClient.CreateProduct(request);
            if (result)
            {
                _notyf.Success("Thêm mới sản phẩm thành công");
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Thêm sản phẩm thất bại");
            return View(request);
        }

        [HttpGet]
        public async Task<IActionResult> CategoryAssign(Guid id)
        {
            var roleAssignRequest = await GetCategoryAssignRequest(id);
            return View(roleAssignRequest);
        }

        [HttpPost]
        public async Task<IActionResult> CategoryAssign(CategoryAssignRequest request)
        {
            if (!ModelState.IsValid)
                return View();

            var result = await _productApiClient.CategoryAssign(request.Id, request);

            if (result.IsSuccessed)
            {
                TempData["result"] = "Cập nhật danh mục thành công";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", result.Message);
            var roleAssignRequest = await GetCategoryAssignRequest(request.Id);

            return View(roleAssignRequest);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {

            var product = await _productApiClient.GetById(id);
            var editVm = new ProductUpdateRequest()
            {
                Id = product.Id,
                Code = product.Code,
                Description = product.Description,
                Detail = product.Detail,
                Name = product.Name,
                Height = product.Height,
                Status = product.Status,
                Width = product.Width,
                ViewCount = product.ViewCount,
                ProductCategories = product.ProductCategories
            };

            return View(editVm);
        }

        [HttpPost]
        //[Consumes("multipart/form-data")]
        public async Task<IActionResult> Edit([FromForm] ProductUpdateRequest request)
        {
            if (!ModelState.IsValid)
                return View(request);

            request.ModifyBy = User.Identity.Name;
            request.ModifyDate = DateTime.Now;


            var result = await _productApiClient.UpdateProduct(request);
            if (result)
            {
                _notyf.Success("Cập nhật sản phẩm thành công");
                return RedirectToAction("Details", new { id = request.Id});
            }

            ModelState.AddModelError("", "Cập nhật sản phẩm thất bại");
            return View(request);
        }

        private async Task<CategoryAssignRequest> GetCategoryAssignRequest(Guid id)
        {

            var productObj = await _productApiClient.GetById(id);
            var categories = await _categoryApiClient.GetAll();
            var categoryAssignRequest = new CategoryAssignRequest();
            foreach (var role in categories)
            {
                categoryAssignRequest.ProductCategories.Add(new SelectItem()
                {
                    Id = role.Id.ToString(),
                    Name = role.Name,
                    Selected = productObj.ProductCategories.Contains(role.Id)
                });
            }
            return categoryAssignRequest;
        }

        [HttpGet]
        public IActionResult Delete(Guid id)
        {
            return View(new ProductVm()
            {
                Id = id
            });
        }

        [HttpPost]
        public async Task<IActionResult> Delete(ProductVm request)
        {
            if (!ModelState.IsValid)
                return View();

            var result = await _productApiClient.DeleteProduct(request.Id);
            if (result)
            {
                TempData["result"] = "Xóa sản phẩm thành công";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Xóa không thành công");
            return View(request);
        }
    }
}
