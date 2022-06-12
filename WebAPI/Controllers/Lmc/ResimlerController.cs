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
    public class ResimlerController : ControllerBase
    {
        ILmcResimService _resimService;

        public ResimlerController(ILmcResimService resimService)
        {
            _resimService = resimService;
        }

        [HttpPost("add")]
        public IActionResult Add([FromForm(Name = ("Image"))] IFormFile file, [FromForm] Resim resim)
        {
            var result = _resimService.Add(file, resim);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete([FromForm(Name = ("Id"))] int Id)
        {
            var silinecekResim = _resimService.GetById(Id).Data;
            
            var result = _resimService.Delete(silinecekResim);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update([FromForm(Name = ("Image"))] IFormFile file, [FromForm] int Id)
        {
            var guncellenecekResim = _resimService.GetById(Id).Data; 
            var result = _resimService.Update(file, guncellenecekResim);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getresimbyresimid")]
        public IActionResult GetResimByResimId(int resimId)
        {
            var result = _resimService.GetById(resimId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpGet("getresimlerbyurunid")]
        public IActionResult GetResimlerByUrunId(int urunId)
        {
            var result = _resimService.GetImagesByUrunId(urunId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result =  _resimService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
