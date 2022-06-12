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
    public class SatinAlimlarController : ControllerBase
    {
        ILmcSatinAlimService _satinAlimService;

        public SatinAlimlarController(ILmcSatinAlimService satinAlimService)
        {
            _satinAlimService = satinAlimService;
        }

        [HttpGet("getall")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _satinAlimService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        


        [HttpGet("getsatinalimbysatinalimid")]
        public async Task<IActionResult> GetSatinAlimBySatinAlimId(int satinAlimId)
        {
            var result = await _satinAlimService.GetBySatinAlimId(satinAlimId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getsatinalimbysepetid")]
        public async Task<IActionResult> GetSatinAlimBySepetId(int sepetId)
        {
            var result = await _satinAlimService.GetBySepetId(sepetId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public async Task<IActionResult> Add(SatinAlim satinAlim)
        {
            var result = await _satinAlimService.Add(satinAlim);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public async Task<IActionResult> Update(SatinAlim satinAlim)
        {
            var result = await _satinAlimService.Update(satinAlim);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public async Task<IActionResult> Delete(SatinAlim satinAlim)
        {
            var result = await _satinAlimService.Delete(satinAlim);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
}
