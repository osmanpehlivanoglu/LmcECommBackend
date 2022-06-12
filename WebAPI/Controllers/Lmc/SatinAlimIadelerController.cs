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
    public class SatinAlimIadelerController : ControllerBase
    {
        ILmcSatinAlimIadeService _satinAlimIadeService;

        public SatinAlimIadelerController(ILmcSatinAlimIadeService satinAlimIadeService)
        {
            _satinAlimIadeService = satinAlimIadeService;
        }

        [HttpGet("getall")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _satinAlimIadeService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getsatinalimiadebysatinalimid")]
        public async Task<IActionResult> GetSatinAlimIadeBySatinAlimId(int satinAlimId)
        {
            var result = await _satinAlimIadeService.GetBySatinAlimId(satinAlimId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpGet("getsatinalimiadebysatinalimiadeid")]
        public async Task<IActionResult> GetSatinAlimIadeBySatinAlimIadeId(int satinAlimIadeId)
        {
            var result = await _satinAlimIadeService.GetById(satinAlimIadeId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public async Task<IActionResult> Add(SatinAlimIade satinAlimIade)
        {
            var result = await _satinAlimIadeService.Add(satinAlimIade);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public async Task<IActionResult> Update(SatinAlimIade satinAlimIade)
        {
            var result = await _satinAlimIadeService.Update(satinAlimIade);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public async Task<IActionResult> Delete(SatinAlimIade satinAlimIade)
        {
            var result = await _satinAlimIadeService.Delete(satinAlimIade);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
