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
    public class YapilanOdemelerController : ControllerBase
    {
        ILmcYapilanOdemeService _yapilanOdemeService;

        public YapilanOdemelerController(ILmcYapilanOdemeService yapilanOdemeService)
        {
            _yapilanOdemeService = yapilanOdemeService;
        }

        [HttpGet("getall")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _yapilanOdemeService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getyapilanodemelerbytoptanciid")]
        public async Task<IActionResult> GetYapilanOdemelerByToptanciId(int toptanciId)
        {
            var result = await _yapilanOdemeService.GetAllByToptanciId(toptanciId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getyapilanodemebyyapilanodemeid")]
        public async Task<IActionResult> GetYapilanOdemeByYapilanOdemeId(int yapilanOdemeId)
        {
            var result = await _yapilanOdemeService.GetById(yapilanOdemeId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public async Task<IActionResult> Add(YapilanOdeme yapilanOdeme)
        {
            var result = await _yapilanOdemeService.Add(yapilanOdeme);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public async Task<IActionResult> Update(YapilanOdeme yapilanOdeme)
        {
            var result = await _yapilanOdemeService.Update(yapilanOdeme);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public async Task<IActionResult> Delete(YapilanOdeme yapilanOdeme)
        {
            var result = await _yapilanOdemeService.Delete(yapilanOdeme);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
