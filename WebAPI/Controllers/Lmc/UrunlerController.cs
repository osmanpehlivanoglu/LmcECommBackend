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
    public class UrunlerController : ControllerBase
    {

        ILmcUrunService _urunService;

        public UrunlerController(ILmcUrunService urunService)
        {
            _urunService = urunService;
        }

        [HttpGet("getall")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _urunService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        
        [HttpGet("geturunlerbykategoriid")]
        public async Task<IActionResult> GetUrunlerByKategoriId(int kategoriId)
        {
            var result = await _urunService.GetAllByCategoryId(kategoriId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("geturunlerbyalisfiyati")]
        public async Task<IActionResult> GetUrunlerByAlisFiyati(decimal min, decimal max)
        {
            var result = await _urunService.GetAllByUnitPricePurchase(min, max);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("geturunlerbytoptancifiyati")]
        public async Task<IActionResult> GetUrunlerByToptanciFiyati(decimal min, decimal max)
        {
            var result = await _urunService.GetAllByUnitPriceGrocer(min, max);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("geturunlerbybayifiyati")]
        public async Task<IActionResult> GetUrunlerByBayiFiyati(decimal min, decimal max)
        {
            var result = await _urunService.GetAllByUnitPriceDealer(min, max);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("geturunlerbyperakendefiyati")]
        public async Task<IActionResult> GetUrunlerByPerakendeFiyati(decimal min, decimal max)
        {
            var result = await _urunService.GetAllByUnitPriceRetail(min, max);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("geturunbyurunid")]
        public async Task<IActionResult> GetUrunByUrunId(int urunId)
        {
            var result = await _urunService.GetById(urunId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public async Task<IActionResult> Add(Urun urun)
        {
            var result = await _urunService.Add(urun);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public async Task<IActionResult> Update(Urun urun)
        {
            var result = await _urunService.Update(urun);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public async Task<IActionResult> Delete(Urun urun)
        {
            var result = await _urunService.Delete(urun);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }








        [HttpGet("getalldto")]
        public async Task<IActionResult> GetAllDto()
        {
            var result = await _urunService.GetAllDto();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("geturunlerdtobykategoriid")]
        public async Task<IActionResult> GetUrunlerDtoByKategoriId(int kategoriId)
        {
            var result = await _urunService.GetAllDtoByCategory(kategoriId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("geturunlerdtobymarkaid")]
        public async Task<IActionResult> GetUrunlerDtoByMarkaId(int markaId)
        {
            var result = await _urunService.GetAllDtoByBrand(markaId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("geturunlerdtobykategoriidvemarkaid")]
        public async Task<IActionResult> GetUrunlerDtoByKategoriIdveMarkaId(int kategoriId, int markaId)
        {
            var result = await _urunService.GetAllDtoByCategoryAndBrand(kategoriId, markaId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("geturundtobyurunid")]
        public async Task<IActionResult> GetUrunDtoByUrunId(int urunId)
        {
            var result = await _urunService.GetDtoByProduct(urunId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }




        //[HttpGet("geturunlerdtobyalisfiyati")]
        //public IActionResult GetUrunlerDtoByAlisFiyati(decimal min, decimal max)
        //{
        //    var result = _urunService.GetAllDtoByUnitPricePurchase(min, max);
        //    if (result.Success)
        //    {
        //        return Ok(result);
        //    }
        //    return BadRequest(result);
        //}
        //[HttpGet("geturunlerdtobytoptancifiyati")]
        //public IActionResult GetUrunlerDtoByToptanciFiyati(decimal min, decimal max)
        //{
        //    var result = _urunService.GetAllDtoByUnitPriceGrocer(min, max);
        //    if (result.Success)
        //    {
        //        return Ok(result);
        //    }
        //    return BadRequest(result);

        //}

        //[HttpGet("geturunlerdtobybayifiyati")]
        //public IActionResult GetUrunlerDtoByBayiFiyati(decimal min, decimal max)
        //{
        //    var result = _urunService.GetAllDtoByUnitPriceDealer(min, max);
        //    if (result.Success)
        //    {
        //        return Ok(result);
        //    }
        //    return BadRequest(result);

        //}

        //[HttpGet("geturunlerdtobyperakendefiyati")]
        //public IActionResult GetUrunlerDtoByPerakendeFiyati(decimal min, decimal max)
        //{
        //    var result = _urunService.GetAllDtoByUnitPriceRetail(min, max);
        //    if (result.Success)
        //    {
        //        return Ok(result);
        //    }
        //    return BadRequest(result);
        //}
    }
}
