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
    public class SatislarController : ControllerBase
    {
        ILmcSatisService _satisService;

        public SatislarController(ILmcSatisService satisService)
        {
            _satisService = satisService;
        }

        [HttpGet("getall")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _satisService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getsatisbysatisid")]
        public async Task<IActionResult> GetSatisBySatisId(int satisId)
        {
            var result = await _satisService.GetBySatisId(satisId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getsatisbysepetid")]
        public async Task<IActionResult> GetSatisBySepetId(int sepetId)
        {
            var result = await _satisService.GetBySepetId(sepetId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public async Task<IActionResult> Add(Satis satis)
        {
            var result = await _satisService.Add(satis);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public async Task<IActionResult> Update(Satis satis)
        {
            var result = await _satisService.Update(satis);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public async Task<IActionResult> Delete(Satis satis)
        {
            var result = await _satisService.Delete(satis);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
