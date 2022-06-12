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
    public class AlinanOdemelerController : ControllerBase
    {
        ILmcAlinanOdemeService _alinanOdemeService;

        public AlinanOdemelerController(ILmcAlinanOdemeService alinanOdemeService)
        {
            _alinanOdemeService = alinanOdemeService;
        }

        [HttpGet("getall")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _alinanOdemeService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getalinanodemelerbymusteriid")]
        public async Task<IActionResult> GetAlinanOdemelerByMusteriId(int musteriId)
        {
            var result = await _alinanOdemeService.GetAllByMusteriId(musteriId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getalinanodemebyalinanodemeid")]
        public async Task<IActionResult> GetAlinanOdemeByAlinanOdemeId(int alinanOdemeId)
        {
            var result = await _alinanOdemeService.GetById(alinanOdemeId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public async Task<IActionResult> Add(AlinanOdeme alinanOdeme)
        {
            var result = await _alinanOdemeService.Add(alinanOdeme);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public async Task<IActionResult> Update(AlinanOdeme alinanOdeme)
        {
            var result = await _alinanOdemeService.Update(alinanOdeme);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public async Task<IActionResult> Delete(AlinanOdeme alinanOdeme)
        {
            var result = await _alinanOdemeService.Delete(alinanOdeme);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
