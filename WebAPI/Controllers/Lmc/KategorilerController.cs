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
    public class KategorilerController : ControllerBase
    {
        ILmcKategoriService _kategoriService;

        public KategorilerController(ILmcKategoriService kategoriService)
        {
            _kategoriService = kategoriService;
        }

        [HttpGet("getall")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _kategoriService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpGet("getkategoribykategoriid")]
        public async Task<IActionResult> GetKategoriByKategoriId(int kategoriId)
        {
            var result = await _kategoriService.GetById(kategoriId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public async Task<IActionResult> Add(Kategori kategori)
        {
            var result = await _kategoriService.Add(kategori);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public async Task<IActionResult> Update(Kategori kategori)
        {
            var result = await _kategoriService.Update(kategori);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public async Task<IActionResult> Delete(Kategori kategori)
        {
            var result = await _kategoriService.Delete(kategori);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
