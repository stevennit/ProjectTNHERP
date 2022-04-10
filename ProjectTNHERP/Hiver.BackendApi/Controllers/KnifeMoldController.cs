using Hiver.Application.Catalog.KnifeMolds;
using Hiver.ViewModels.Catalog.KnifeMoldImages;
using Hiver.ViewModels.Catalog.KnifeMolds;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Hiver.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KnifeMoldController : ControllerBase
    {
        private readonly IKnifeMoldService _tableService;

        public KnifeMoldController(IKnifeMoldService tableService)
        {
            _tableService = tableService;
        }


        //http://localhost/api/users/paging?pageIndex=1&pageSize=10&keyword=
        [HttpGet("paging")]
        //[ServiceFilter(typeof(AuthAttribute))]
        public async Task<IActionResult> GetAllPaging([FromQuery] GetAllKnifeMoldPagingRequest request)
        {
            var tables = await _tableService.GetAllPaging(request);
            return Ok(tables);
        }

        [HttpGet("{Id}")]
        //[ServiceFilter(typeof(AuthAttribute))]
        public async Task<IActionResult> GetById(Guid Id)
        {
            var tables = await _tableService.GetById(Id);
            if (tables == null)
                return BadRequest("Không tìm thấy");
            return Ok(tables);
        }

        [HttpPost]
        [Consumes("multipart/form-data")]
        //[ServiceFilter(typeof(AuthAttribute))]
        public async Task<IActionResult> Create([FromForm] KnifeMoldCreateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var Id = await _tableService.Create(request);
            if (Id == Guid.Empty)
                return BadRequest();

            var table = await _tableService.GetById(Id);

            return CreatedAtAction(nameof(GetById), new { id = Id }, table);
        }

        [HttpPut]
        [Consumes("multipart/form-data")]
        //[ServiceFilter(typeof(AuthAttribute))]
        public async Task<IActionResult> Update([FromForm] KnifeMoldUpdateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var affectedResult = await _tableService.Update(request);
            if (affectedResult == System.Guid.Empty)
                return BadRequest();
            return Ok();
        }

        [HttpDelete]
        //[ServiceFilter(typeof(AuthAttribute))]
        public async Task<IActionResult> Delete(Guid Id)
        {
            var affectedResult = await _tableService.Delete(Id);
            if (affectedResult == Guid.Empty)
                return BadRequest();
            return Ok();
        }

        //Images
        [HttpPost("{productId}/images")]
        //[ServiceFilter(typeof(AuthAttribute))]
        public async Task<IActionResult> CreateImage(Guid Id, [FromForm] KnifeMoldImageCreateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var imageId = await _tableService.AddImage(Id, request);
            if (imageId == 0)
                return BadRequest();

            var image = await _tableService.GetImageById(imageId);

            return CreatedAtAction(nameof(GetImageById), new { id = imageId }, image);
        }

        [HttpPut("{productId}/images/{imageId}")]
        //[ServiceFilter(typeof(AuthAttribute))]
        public async Task<IActionResult> UpdateImage(int imageId, [FromForm] KnifeMoldImageUpdateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = await _tableService.UpdateImage(imageId, request);
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
            var result = await _tableService.RemoveImage(imageId);
            if (result == 0)
                return BadRequest();

            return Ok();
        }

        //[ServiceFilter(typeof(AuthAttribute))]
        [HttpGet("{productId}/images/{imageId}")]
        public async Task<IActionResult> GetImageById(Guid productId, int imageId)
        {
            var image = await _tableService.GetImageById(imageId);
            if (image == null)
                return BadRequest("Không tìm thấy ảnh");
            return Ok(image);
        }
    }
}
