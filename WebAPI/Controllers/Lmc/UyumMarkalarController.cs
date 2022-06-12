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
    public class UyumMarkalarController : ControllerBase
    {
        ILmcUyumMarkaService _uyumMarkaService;

        public UyumMarkalarController(ILmcUyumMarkaService uyumMarkaService)
        {
            _uyumMarkaService = uyumMarkaService;
        }

        [HttpGet("getall")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _uyumMarkaService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpGet("getuyummarkabyuyummarkaid")]
        public async Task<IActionResult> GetUyumMarkaByUyumMarkaId(int uyumMarkaId)
        {
            var result = await _uyumMarkaService.GetById(uyumMarkaId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public async Task<IActionResult> Add(UyumMarka uyumMarka)
        {
            var result = await _uyumMarkaService.Add(uyumMarka);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public async Task<IActionResult> Update(UyumMarka uyumMarka)
        {
            var result = await _uyumMarkaService.Update(uyumMarka);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public async Task<IActionResult> Delete(UyumMarka uyumMarka)
        {
            var result = await _uyumMarkaService.Delete(uyumMarka);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
