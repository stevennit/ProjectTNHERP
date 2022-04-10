using Hiver.Application.Catalog.Partners;
using Hiver.ViewModels.Catalog.Partners;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Hiver.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IPartnerService _customerService;

        public CustomerController(IPartnerService customerService)
        {
            _customerService = customerService;
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

            var Id = await _customerService.Create(request);
            if (Id == 0)
                return BadRequest();

            var table = await _customerService.GetById(Id);

            return CreatedAtAction(nameof(GetById), new { id = Id }, table);
        }

        [HttpGet("{Id}")]
        //[ServiceFilter(typeof(AuthAttribute))]
        public async Task<IActionResult> GetById(int Id)
        {
            var tables = await _customerService.GetById(Id);
            if (tables == null)
                return BadRequest("Không tìm thấy khách hàng");
            return Ok(tables);
        }

        ////http://localhost/api/users/paging?pageIndex=1&pageSize=10&keyword=
        //[HttpGet("paging")]
        ////[ServiceFilter(typeof(AuthAttribute))]
        //public async Task<IActionResult> GetAllPaging([FromQuery] GetPartnerPagingRequest request)
        //{
        //    var tables = await _customerService.GetAllPaging(request);
        //    return Ok(tables);
        //}

        [HttpPut]
        [Consumes("multipart/form-data")]
        //[ServiceFilter(typeof(AuthAttribute))]
        public async Task<IActionResult> Update([FromForm] PartnerUpdateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var affectedResult = await _customerService.Update(request);
            if (affectedResult == 0)
                return BadRequest();

            return Ok();
        }

        [HttpDelete]
        //[ServiceFilter(typeof(AuthAttribute))]
        public async Task<IActionResult> Delete(int Id)
        {
            var affectedResult = await _customerService.Delete(Id);
            if (affectedResult == 0)
                return BadRequest();
            return Ok();
        }
    }
}
