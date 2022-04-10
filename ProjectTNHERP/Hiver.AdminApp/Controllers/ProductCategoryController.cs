using Hiver.ApiIntegration.ProductCategory;
using Hiver.ViewModels.Catalog.ProductCategories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hiver.AdminApp.Controllers
{
    
    public class ProductCategoryController : BaseController
    {
        private readonly IProductCategoryApiClient _productCategoryApiClient;
        public ProductCategoryController(IProductCategoryApiClient productCategoryApiClient)
        {
            _productCategoryApiClient = productCategoryApiClient;
        }
        public async Task<IActionResult> Index(string keyword, Guid? categoryId, int pageIndex = 1, int pageSize = 10)
        {

            var request = new GetAllProductCategoryPagingRequest()
            {
                Keyword = keyword,
                PageIndex = pageIndex,
                PageSize = pageSize
            };
            var data = await _productCategoryApiClient.GetAllPaging(request);

            ViewBag.Keyword = keyword;

            var categories = await _productCategoryApiClient.GetAll();

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

        public async Task<IActionResult> Details(int Id)
        {
            var table = await _productCategoryApiClient.GetById(Id);

            return View(table);
        }
        
    }
}
