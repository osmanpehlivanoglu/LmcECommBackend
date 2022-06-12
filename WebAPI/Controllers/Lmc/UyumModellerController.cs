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
    public class UyumModellerController : ControllerBase
    {
        ILmcUyumModelService _uyumModelService;

        public UyumModellerController(ILmcUyumModelService uyumModelService)
        {
            _uyumModelService = uyumModelService;
        }

        [HttpGet("getall")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _uyumModelService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getuyummodellerbyuyummarkaid")]
        public async Task<IActionResult> GetUyumModellerByUyumMarkaId(int uyumMarkaId)
        {
            var result = await _uyumModelService.GetAllByUyumMarkaId(uyumMarkaId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getuyummodelbyuyummodelid")]
        public async Task<IActionResult> GetUyumModelByUyumModelId(int uyumModelId)
        {
            var result = await _uyumModelService.GetById(uyumModelId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public async Task<IActionResult> Add(UyumModel uyumModel)
        {
            var result = await _uyumModelService.Add(uyumModel);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public async Task<IActionResult> Update(UyumModel uyumModel)
        {
            var result = await _uyumModelService.Update(uyumModel);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public async Task<IActionResult> Delete(UyumModel uyumModel)
        {
            var result = await _uyumModelService.Delete(uyumModel);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
