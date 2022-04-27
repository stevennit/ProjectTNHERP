using Hiver.ApiIntegration.Product;
using Hiver.ViewModels.Catalog.Products;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hiver.AdminApp.Controllers.Components
{
    public class ProductImageFirstViewComponent : ViewComponent
    {
        private readonly IProductApiClient _productApiClient;

        public ProductImageFirstViewComponent(IProductApiClient productApiClient)
        {
            _productApiClient = productApiClient;
        }

        public Task<IViewComponentResult> InvokeAsync(Guid IdProduct)
        {
            var children = GetImageProduct(IdProduct);

            return Task.FromResult((IViewComponentResult)View("Default", children));
        }

        public ProductImageFirst GetImageProduct(Guid IdProduct)
        {
            var res = _productApiClient.GetProductImageFirst(IdProduct);

            return res.Result;
        }
    }
}
