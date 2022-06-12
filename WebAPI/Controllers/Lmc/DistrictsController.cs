using Business.Abstract.Lmc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers.Lmc
{
    [Route("api/lmc/[controller]")]
    [ApiController]
    public class DistrictsController : ControllerBase
    {
        ILmcDistrictService _districtService;

        public DistrictsController(ILmcDistrictService districtService)
        {
            _districtService = districtService;
        }

        [HttpGet("getall")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _districtService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getallbycityid")]
        public async Task<IActionResult> GetAllByCityId(int cityId)
        {
            var result = await _districtService.GetAllByCityId(cityId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public async Task<IActionResult> GetById(int districtId)
        {
            var result = await _districtService.GetById(districtId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
