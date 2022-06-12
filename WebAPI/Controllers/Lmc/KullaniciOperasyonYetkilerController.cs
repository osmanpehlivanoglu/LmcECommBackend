using Business.Abstract;
using Core.Entities.Concrete;
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
    public class KullaniciOperasyonYetkilerController : ControllerBase
    {
        ILmcUserOperationClaimService _userOperationClaimService;

        public KullaniciOperasyonYetkilerController(ILmcUserOperationClaimService userOperationClaimService)
        {
            _userOperationClaimService = userOperationClaimService;
        }

        [HttpGet("getall")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _userOperationClaimService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getoperasyonyetkilerbykullaniciid")]
        public async Task<IActionResult> GetKullaniciOperasyonYetkilerByKullaniciId(int kullaniciId)
        {
            var result = await _userOperationClaimService.GetByUserId(kullaniciId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getkullanicioperasyonyetkibykullanicioperasyonyetkiid")]
        public async Task<IActionResult> GetKullaniciOperasyonYetkiByKullaniciOperasyonYetkiId(int kullaniciOperasyonYetkiId)
        {
            var result = await _userOperationClaimService.GetById(kullaniciOperasyonYetkiId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public async Task<IActionResult> Add(UserOperationClaim userOperationClaim)
        {
            var result = await _userOperationClaimService.Add(userOperationClaim);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public async Task<IActionResult> Update(UserOperationClaim userOperationClaim)
        {
            var result = await _userOperationClaimService.Update(userOperationClaim);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public async Task<IActionResult> Delete(UserOperationClaim userOperationClaim)
        {
            var result = await _userOperationClaimService.Delete(userOperationClaim);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
}
