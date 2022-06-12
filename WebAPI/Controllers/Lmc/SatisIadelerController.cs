using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/lmc/[controller]")]
    [ApiController]
    public class SatisIadelerController : ControllerBase
    {
        ILmcSatisIadeService _satisIadeService;

        public SatisIadelerController(ILmcSatisIadeService satisIadeService)
        {
            _satisIadeService = satisIadeService;
        }

        [HttpGet("getall")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _satisIadeService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getsatisiadebysatisid")]
        public async Task<IActionResult> GetSatisIadeBySatisId(int satisId)
        {
            var result = await _satisIadeService.GetBySatisId(satisId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpGet("getsatisiadebysatisiadeid")]
        public async Task<IActionResult> GetSatisIadeBySatisIadeId(int satisIadeId)
        {
            var result = await _satisIadeService.GetById(satisIadeId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public async Task<IActionResult> Add(SatisIade satisIade)
        {
            var result = await _satisIadeService.Add(satisIade);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public async Task<IActionResult> Update(SatisIade satisIade)
        {
            var result = await _satisIadeService.Update(satisIade);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public async Task<IActionResult> Delete(SatisIade satisIade)
        {
            var result = await _satisIadeService.Delete(satisIade);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
