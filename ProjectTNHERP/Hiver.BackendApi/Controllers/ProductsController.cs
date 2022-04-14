using Hiver.Application.Catalog.Products;
using Hiver.BackendApi.Auth;
using Hiver.ViewModels.Catalog.ProductImages;
using Hiver.ViewModels.Catalog.Products;
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
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }


        //http://localhost/api/users/paging?pageIndex=1&pageSize=10&keyword=
        [HttpGet("paging")]
        //[ServiceFilter(typeof(AuthAttribute))]
        public async Task<IActionResult> GetAllPaging([FromQuery] GetManageProductPagingRequest request)
        {
            var products = await _productService.GetAllPaging(request);
            return Ok(products);
        }

        [HttpGet("{Id}")]
        //[ServiceFilter(typeof(AuthAttribute))]
        public async Task<IActionResult> GetById(Guid Id)
        {
            var product = await _productService.GetById(Id);
            if (product == null)
                return BadRequest("Không tìm thấy sản phẩm");
            return Ok(product);
        }

        [HttpPost]
        [Consumes("multipart/form-data")]
        //[ServiceFilter(typeof(AuthAttribute))]
        public async Task<IActionResult> Create([FromForm] ProductVm request)
        {
            if (!ModelState.IsValid)
            {   
                return BadRequest(ModelState);
            }

            var Id = await _productService.Create(request);
            if (Id == Guid.Empty)
                return BadRequest();

            var table = await _productService.GetById(Id);

            return CreatedAtAction(nameof(GetById), new { id = Id }, table);
        }

        [HttpPut("{Id}")]
        [Consumes("multipart/form-data")]
        [ServiceFilter(typeof(AuthAttribute))]
        public async Task<IActionResult> Update([FromRoute] Guid Id,[FromForm] ProductVm request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            request.Id = Id;

            var affectedResult = await _productService.Update(request);
            if (affectedResult == Guid.Empty)
                return BadRequest();
            return Ok();
        }

        [HttpDelete]
        //[ServiceFilter(typeof(AuthAttribute))]
        public async Task<IActionResult> Delete(Guid Id)
        {
            var affectedResult = await _productService.Delete(Id);
            if (affectedResult == Guid.Empty)
                return BadRequest();
            return Ok();
        }

        //Images
        [HttpPost("{productId}/images")]
        //[ServiceFilter(typeof(AuthAttribute))]
        public async Task<IActionResult> CreateImage(Guid productId, [FromForm] ProductImageCreateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var imageId = await _productService.AddImage(productId, request);
            if (imageId == 0)
                return BadRequest();

            var image = await _productService.GetImageById(imageId);

            return CreatedAtAction(nameof(GetImageById), new { id = imageId }, image);
        }

        [HttpPut("{productId}/images/{imageId}")]
        //[ServiceFilter(typeof(AuthAttribute))]
        public async Task<IActionResult> UpdateImage(int imageId, [FromForm] ProductImageUpdateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = await _productService.UpdateImage(imageId, request);
            if (result == 0)
                return BadRequest();

            return Ok();
        }

        [HttpDelete("{productId}/images/{imageId}")]
        //[ServiceFilter(typeof(AuthAttribute))]
        public async Task<IActionResult> RemoveImage(int imageId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = await _productService.RemoveImage(imageId);
            if (result == 0)
                return BadRequest();

            return Ok();
        }


        //[ServiceFilter(typeof(AuthAttribute))]
        [HttpGet("{productId}/images/{imageId}")]
        public async Task<IActionResult> GetImageById(Guid productId, int imageId)
        {
            var image = await _productService.GetImageById(imageId);
            if (image == null)
                return BadRequest("Không tìm thấy ảnh");
            return Ok(image);
        }

        [HttpPut("{id}/productassign")]
        public async Task<IActionResult> RoleAssign(Guid id, [FromBody] CategoryAssignRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _productService.ProductAssignCategory(id, request);
            if (!result.IsSuccessed)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }
    }
}
