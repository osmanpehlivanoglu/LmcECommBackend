using Business.Abstract.Lmc;
using Entities.Concrete;
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
    public class BegenilerController : ControllerBase
    {
        ILmcBegeniService _begeniService;

        public BegenilerController(ILmcBegeniService begeniService)
        {
            _begeniService = begeniService;
        }

        [HttpGet("getall")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _begeniService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpGet("getbegenibybegeniid")]
        public async Task<IActionResult> GetBegeniByBegeniId(int begeniId)
        {
            var result = await _begeniService.GetById(begeniId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbegenilerbykullaniciid")]
        public async Task<IActionResult> GetBegenilerByKullaniciId(int kullaniciId)
        {
            var result = await _begeniService.GetById(kullaniciId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public async Task<IActionResult> Add(Begeni begeni)
        {
            var result = await _begeniService.Add(begeni);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public async Task<IActionResult> Update(Begeni begeni)
        {
            var result = await _begeniService.Update(begeni);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public async Task<IActionResult> Delete(Begeni begeni)
        {
            var result = await _begeniService.Delete(begeni);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getalldto")]
        public async Task<IActionResult> GetAllDto()
        {
            var result = await _begeniService.GetAllDto();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getalldtobykullaniciid")]
        public async Task<IActionResult> GetAllDtoByUrunId(int kullaniciId)
        {
            var result = await _begeniService.GetAllDtoByKullaniciId(kullaniciId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
