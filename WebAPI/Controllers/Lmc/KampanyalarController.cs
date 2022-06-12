using Business.Abstract.Lmc;
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
    public class KampanyalarController : ControllerBase
    {
        ILmcKampanyaService _kampanyaService;

        public KampanyalarController(ILmcKampanyaService kampanyaService)
        {
            _kampanyaService = kampanyaService;
        }

        [HttpGet("getall")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _kampanyaService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpGet("getkampanyabykampanyaid")]
        public async Task<IActionResult> GetKampanyaByKampanyaId(int kampanyaId)
        {
            var result = await _kampanyaService.GetById(kampanyaId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getkampanyabyurunid")]
        public async Task<IActionResult> GetKampanyaByUrunId(int urunId)
        {
            var result = await _kampanyaService.GetById(urunId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public async Task<IActionResult> Add(Kampanya kampanya)
        {
            var result = await _kampanyaService.Add(kampanya);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public async Task<IActionResult> Update(Kampanya kampanya)
        {
            var result = await _kampanyaService.Update(kampanya);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public async Task<IActionResult> Delete(Kampanya kampanya)
        {
            var result = await _kampanyaService.Delete(kampanya);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getalldto")]
        public async Task<IActionResult> GetAllDto()
        {
            var result = await _kampanyaService.GetAllDto();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpGet("getkampanyadtobyurunid")]
        public async Task<IActionResult> GetKampanyaDtoByUrunId(int urunId)
        {
            var result = await _kampanyaService.GetDtoByUrunId(urunId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
