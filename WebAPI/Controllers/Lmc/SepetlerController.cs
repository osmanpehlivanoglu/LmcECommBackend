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
    public class SepetlerController : ControllerBase
    {
        ILmcSepetService _sepetService;

        public SepetlerController(ILmcSepetService sepetService)
        {
            _sepetService = sepetService;
        }

        [HttpGet("getall")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _sepetService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getsepetbysepetid")]
        public async Task<IActionResult> GetSepetBySepetId(int sepetId)
        {
            var result = await _sepetService.GetSepetBySepetId(sepetId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getsepetbyonayidandtarih")]
        public async Task<IActionResult> GetSepetByOnayIdAndTarih(int onayId, string tarih)
        {
            var result = await _sepetService.GetSepetByOnayIdAndDate(onayId, tarih);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getsepetbymusteriidanddurum")]
        public async Task<IActionResult> GetSepetByMusteriIdAndDurum(int musteriId, bool durum)
        {
            var result = await _sepetService.GetAllByMusteriIdAndDurum(musteriId, durum);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public async Task<IActionResult> Add(Sepet sepet)
        {
            var result = await _sepetService.Add(sepet);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public async Task<IActionResult> Update(Sepet sepet)
        {
            var result = await _sepetService.Update(sepet);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public async Task<IActionResult> Delete(Sepet sepet)
        {
            var result = await _sepetService.Delete(sepet);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }




        [HttpGet("getalldto")]
        public async Task<IActionResult> GetAllDto()
        {
            var result = await _sepetService.GetAllDto();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpGet("getsepetdtobysepetid")]
        public async Task<IActionResult> GetUrunDtoByUrunId(int sepetId)
        {
            var result = await _sepetService.GetDtoBySepetId(sepetId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getsepetlerdtobyonayidanddurum")]
        public async Task<IActionResult> GetSepetlerDtoByOnayIdAndDurum(int onayId, bool durum)
        {
            var result = await _sepetService.GetAllDtoByOnayIdAndDurum(onayId, durum);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        


        [HttpGet("getsepetlerdtobymusteriidanddurum")]
        public async Task<IActionResult> GetSepetlerDtoByMusteriIdAndDurum(int musteriId, bool durum)
        {
            var result = await _sepetService.GetAllDtoByMusteriIdAndDurum(musteriId, durum);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getsepetlerdtobymusteriidanddurumandonayid")]
        public async Task<IActionResult> GetSepetlerDtoByMusteriIdAndDurumAndOnayId(int musteriId, bool durum, int onayId)
        {
            var result = await _sepetService.GetAllDtoByMusteriIdAndDurumAndOnayId(musteriId, durum, onayId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
