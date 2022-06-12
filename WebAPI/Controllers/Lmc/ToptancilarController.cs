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
    public class ToptancilarController : ControllerBase
    {
        ILmcToptanciService _toptanciService;

        public ToptancilarController(ILmcToptanciService toptanciService)
        {
            _toptanciService = toptanciService;
        }

        [HttpGet("getall")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _toptanciService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpGet("gettoptancibytoptanciid")]
        public async Task<IActionResult> GetToptanciByToptanciId(int toptanciId)
        {
            var result = await _toptanciService.GetById(toptanciId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public async Task<IActionResult> Add(Toptanci toptanci)
        {
            var result = await _toptanciService.Add(toptanci);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public async Task<IActionResult> Update(Toptanci toptanci)
        {
            var result = await _toptanciService.Update(toptanci);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public async Task<IActionResult> Delete(Toptanci toptanci)
        {
            var result = await _toptanciService.Delete(toptanci);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
