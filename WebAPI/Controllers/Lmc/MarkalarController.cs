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
    public class MarkalarController : ControllerBase
    {
        ILmcMarkaService _markaService;

        public MarkalarController(ILmcMarkaService markaService)
        {
            _markaService = markaService;
        }

        [HttpGet("getall")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _markaService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getmarkalarbykategoriid")]
        public async Task<IActionResult> GetMarkalarByKategoriId(int kategoriId)
        {
            var result = await _markaService.GetAllByKategoriId(kategoriId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getmarkabymarkaid")]
        public async Task<IActionResult> GetMarkaByMarkaId(int markaId)
        {
            var result = await _markaService.GetById(markaId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public async Task<IActionResult> Add(Marka marka)
        {
            var result = await _markaService.Add(marka);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public async Task<IActionResult> Update(Marka marka)
        {
            var result = await _markaService.Update(marka);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public async Task<IActionResult> Delete(Marka marka)
        {
            var result = await _markaService.Delete(marka);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
