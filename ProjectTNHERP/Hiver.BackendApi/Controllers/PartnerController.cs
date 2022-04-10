using Hiver.Application.Catalog.Partners;
using Hiver.ViewModels.Catalog.Partners;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Hiver.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PartnerController : ControllerBase
    {
        private readonly IPartnerService _partnerService;

        public PartnerController(IPartnerService partnerService)
        {
            _partnerService = partnerService;
        }

        [HttpPost]
        [Consumes("multipart/form-data")]
        //[ServiceFilter(typeof(AuthAttribute))]
        public async Task<IActionResult> Create([FromForm] PartnerCreateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var Id = await _partnerService.Create(request);
            if (Id == System.Guid.Empty)
                return BadRequest();

            var table = await _partnerService.GetById(Id);

            return CreatedAtAction(nameof(GetById), new { id = Id }, table);
        }

        [HttpGet("{Id}")]
        //[ServiceFilter(typeof(AuthAttribute))]
        public async Task<IActionResult> GetById(Guid Id)
        {
            var tables = await _partnerService.GetById(Id);
            if (tables == null)
                return BadRequest("Không tìm thấy khách hàng");
            return Ok(tables);
        }

        //http://localhost/api/users/paging?pageIndex=1&pageSize=10&keyword=
        [HttpGet("paging")]
        //[ServiceFilter(typeof(AuthAttribute))]
        public async Task<IActionResult> GetAllPaging([FromQuery] GetPartnerPagingRequest request)
        {
            var tables = await _partnerService.GetAllPaging(request);
            return Ok(tables);
        }

        [HttpPut]
        [Consumes("multipart/form-data")]
        //[ServiceFilter(typeof(AuthAttribute))]
        public async Task<IActionResult> Update([FromForm] PartnerUpdateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var affectedResult = await _partnerService.Update(request);
            if (affectedResult == System.Guid.Empty)
                return BadRequest();

            return Ok();
        }

        [HttpDelete]
        //[ServiceFilter(typeof(AuthAttribute))]
        public async Task<IActionResult> Delete(Guid Id)
        {
            var affectedResult = await _partnerService.Delete(Id);
            if (affectedResult == Guid.Empty)
                return BadRequest();
            return Ok();
        }
    }
}
