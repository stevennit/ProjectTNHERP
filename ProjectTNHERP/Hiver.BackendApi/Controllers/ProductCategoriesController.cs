using Hiver.Application.Catalog.ProductCategories;
using Hiver.ViewModels.Catalog.ProductCategories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hiver.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductCategoriesController : ControllerBase
    {
        private readonly IProductCategoryService _productCategoryService;

        public ProductCategoriesController(IProductCategoryService productCategoryService)
        {
            _productCategoryService = productCategoryService;
        }


        [HttpGet("paging")]
        //[ServiceFilter(typeof(AuthAttribute))]
        public async Task<IActionResult> GetAllPaging([FromQuery] GetPublicProductCategoryPagingRequest request)
        {
            var products = await _productCategoryService.GetAllPaging(request);
            return Ok(products);
        }

        [HttpGet("{Id}")]
        //[ServiceFilter(typeof(AuthAttribute))]
        public async Task<IActionResult> GetById(int Id)
        {
            var product = await _productCategoryService.GetById(Id);
            if (product == null)
                return BadRequest("Không tìm thấy sản phẩm");
            return Ok(product);
        }

        [HttpPost]
        [Consumes("multipart/form-data")]
        //[ServiceFilter(typeof(AuthAttribute))]
        public async Task<IActionResult> Create([FromForm] ProductCategoryCreateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var Id = await _productCategoryService.Create(request);
            if (Id == 0)
                return BadRequest();

            var table = await _productCategoryService.GetById(Id);

            return CreatedAtAction(nameof(GetById), new { id = Id }, table);
        }

        [HttpPut("{productCategoryId}")]
        [Consumes("multipart/form-data")]
        //[ServiceFilter(typeof(AuthAttribute))]
        public async Task<IActionResult> Update([FromRoute] int productCategoryId,[FromForm] ProductCategoryUpdateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            request.Id = productCategoryId;

            var affectedResult = await _productCategoryService.Update(request);
            if (affectedResult == 0)
                return BadRequest();
            return Ok();
        }

        [HttpDelete]
        //[ServiceFilter(typeof(AuthAttribute))]
        public async Task<IActionResult> Delete(int Id)
        {
            var affectedResult = await _productCategoryService.Delete(Id);
            if (affectedResult == 0)
                return BadRequest();
            return Ok();
        }
    }
}
