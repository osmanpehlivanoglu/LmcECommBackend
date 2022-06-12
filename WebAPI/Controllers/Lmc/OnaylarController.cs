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
    public class OnaylarController : ControllerBase
    {
        ILmcOnayService _onayService;

        public OnaylarController(ILmcOnayService onayService)
        {
            _onayService = onayService;
        }

        [HttpGet("getall")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _onayService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getonaybyonayid")]
        public async Task<IActionResult> GetSatisBySatisId(int onayId)
        {
            var result = await _onayService.GetById(onayId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public async Task<IActionResult> Add(Onay onay)
        {
            var result = await _onayService.Add(onay);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public async Task<IActionResult> Update(Onay onay)
        {
            var result = await _onayService.Update(onay);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public async Task<IActionResult> Delete(Onay onay)
        {
            var result = await _onayService.Delete(onay);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
