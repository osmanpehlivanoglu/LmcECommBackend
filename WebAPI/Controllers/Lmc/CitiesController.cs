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
    public class CitiesController : ControllerBase
    {
        ILmcCityService _cityService;

        public CitiesController(ILmcCityService cityService)
        {
            _cityService = cityService;
        }

        [HttpGet("getall")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _cityService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public async Task<IActionResult> GetById(int cityId)
        {
            var result = await _cityService.GetById(cityId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
